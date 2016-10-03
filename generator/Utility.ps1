# join an array of lines into a string
function Join-Lines()
{
  param($arr)
  [string]($arr -join "`n")
}

# tabinate a line by N tabs
function Tabinate-Line()
{
  param($line, [int]$tabcount)
  if ($line.StartsWith("<#")) { return $line }
  [string]$sb = [string]""
  For ($i = 0; $i -lt $tabcount; $i++) {
    [string]$sb += [string]"    "
  }
  [string]$sb += [string]$line
  $sb
}

# load a cst template from disk
function Load-Template()
{
  param($path, [int]$tabcount)
  $lines = @()
  Get-Content -Path $path | ForEach-Object {
    $lines += Tabinate-Line $_ $tabcount
  }
  Join-Lines $lines
}

[string]$messageFieldTemplate = Load-Template generator/templates/MessageField.cst 3

# build a message field list from a message object
function Build-Message-Fields()
{
    param($m)
    $out = @()
    $m.field | ForEach-Object {
        $f = $_
        $msgTemplate = $messageFieldTemplate -replace "<#msgFieldName#>", $f.name
        $fieldName = if ($m.name -eq $f.name) { [string]::Format("{0}Field", $f.name) } else { $f.name }
        $out += $msgTemplate -replace "<#msgFieldMember#>", $fieldName
        $out += ""
    }
    Join-Lines $out
}

# for loading component groups
function Build-Group() {
    param($g)
    $attr = @{}
    $g.Attributes | ForEach-Object {
        $name = $_.Name
        $val = $_.Value
        $attr.Add($name, $val) | Out-Null
    }
    $fields = @()
    $groups = @()
    $g.ChildNodes | ForEach-Object {
        $tag = $_.LocalName
        if ($tag -eq "field") {
            $fields += Build-Field $_
        }
        if ($tag -eq "group") {
            $groups += Build-Group $_
        }
        # no nested components
    }
    @{ "name" = $attr["name"]; "required" = $attr["required"]; "fields" = $fields; "groups" = $groups }
}

# returns field object, leaf node
function Build-Field() {
    param($f)
    $attr = @{}
    $f.Attributes | ForEach-Object {
        $name = $_.Name
        $val = $_.Value
        $attr.Add($name, $val) | Out-Null
    }
    @{ "name" = $attr["name"]; "required" = $attr["required"] }
}

# load FIX data dicitonary component macros from a data dictionary
function Load-Components()
{
    param($dd)
    $components = @{}
    if ($dd.components -ne $nil -And $dd.components.component -ne $nil) {
        $dd.components.component | ForEach-Object {
            $c = $_
            $fields = @()
            $groups = @()
            if (-Not ($components.ContainsKey($c.name))) {
                if ($c.field -ne $nil) {
                    if (-Not ($c.field -is [system.array])) {
                        $fs = @($c.field)
                    } else {
                        $fs = $c.field
                    }
                    $fs | ForEach-Object {
                        $fields += Build-Field $_
                    }
                }
                if ($c.group -ne $nil) {
                    if (-Not ($c.group -is [system.array])) {
                        $gs = @($c.group)
                    } else {
                        $gs = $c.group
                    }
                    $gs | ForEach-Object {
                        $groups += Build-Group $_
                    }
                }
                $set = @{ "fields" = $fields; "groups" = $groups }
                $components.Add($c.name, $set) | Out-Null
            }
        }
    }
    $components
}

# tabinate an array of lines by N tabs
function Tabinate-Lines()
{
  param($data, [int]$tabcount)
  $out = @()
  $lines = @()
  if ([int]$data.Count -eq 1) {
    $lines += $data
  } else {
    $lines = $data
  }
  $lines | ForEach-Object {
    $out += Tabinate-Line $_ $tabcount
  }
  $out
}

# prepend lines with string
function Prepend-Lines()
{
  param($data, [string]$pre)
  $out = @()
  $lines = @()
  if ([int]$data.Count -eq 1) {
    $lines += $data
  } else {
    $lines = $data
  }
  $lines | ForEach-Object {
    $out += [string]::Format("{0}{1}", $pre, $_)
  }
  $out
}

# extract FIX version from data dictionary
function Fix-Version()
{
  param($dataDictionary)
  [string] $fixType = if ([string]::IsNullOrEmpty($dataDictionary.type)) { "FIX" } else { $dataDictionary.type }
  [string] $versionPrefix = [string]::Format("{0}{1}{2}", $fixType, $dataDictionary.major, $dataDictionary.minor)
  [string] $fixVersion = if ([string]::IsNullOrEmpty($dataDictionary.servicepack) -or $dataDictionary.servicepack -eq "0") { $versionPrefix } else { [string]::Format("{0}SP{1}", $versionPrefix, $dataDictionary.servicepack) }
  $fixVersion
}

# write a string of C# code to a generated file
function Write-Code()
{
  param($path, $code)
  [string]$warning = "// This is a generated file.  Don't edit it directly!`n`n";
  [string]$out = [string]::Format("{0}{1}`n", $warning, $code)
  $status = New-Item $path -type file -force -value $out
}

# build a non-leaf object (message or group)
function Build-Object() {
    param($o)

    $objAttr = @{}
    $o.Attributes | ForEach-Object {
        $name = $_.Name
        $val = $_.Value
        $objAttr.Add($name, $val) | Out-Null
    }

    $obj = @{ "name" = $objAttr["name"] }

    $fields = @()
    $groups = @()

    # walk XML tags and build a set of fields and groups, expanding component tags
    # in the process
    $o.ChildNodes | ForEach-Object {
        $tag = $_.LocalName
        $attr = @{}
        $_.Attributes | ForEach-Object {
            $name = $_.Name
            $val = $_.Value
            $attr.Add($name, $val) | Out-Null
        }
        if ($tag -eq "field") {
            $fields += Build-Field $_
        }
        if ($tag -eq "group") {
            $groups += Build-Object $_
        }
        if ($tag -eq "component") {
            # substitute component lookups
            $set = $components.Get_Item($_.Name)
            if ($set.fields -ne $nil) {
                $set.fields | ForEach-Object {
                    $fields += $_
                }
            }
            if ($set.groups -ne $nil) {
                $set.groups | ForEach-Object {
                    $groups += $_
                }
            }
        }
    }

    if ($objAttr.ContainsKey("required")) {
        $obj | Add-Member "required" $objAttr["required"]
    }
    if ($objAttr.ContainsKey("msgtype")) {
        $obj | Add-Member "msgtype" $objAttr["msgtype"]
    }
    $obj | Add-Member "fields" $fields
    $obj | Add-Member "groups" $groups
    $obj
}

# expand components in DD
function Get-Data-Dictionary() {
    param($xml)
    $fixVersion = Fix-Version $xml
    Write-Host "using FIX version $($fixVersion)"
    $dd = $xml.fix
    $components = Load-Components $dd
    $messages = @()
    $dd.messages.message | ForEach-Object {
        $messages += Build-Object $_
    }
    @{ "messages" = $messages; "version" = $fixVersion }
}
