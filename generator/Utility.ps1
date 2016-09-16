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

# load FIX data dicitonary component macros from a data dictionary
function Load-Components()
{
    param($dd)
    $components = @{}
    if ($dd.components -ne $nil -And $dd.components.component -ne $nil) {
        $dd.components.component | ForEach-Object {
            $c = $_
            if (-Not ($components.ContainsKey($c.name))) {
                if ($c.field -ne $nil) {
                    if (-Not ($c.field -is [system.array])) {
                        $fs = @($c.field)
                    } else {
                        $fs = $c.field
                    }
                    $fields = @()
                    $fs | ForEach-Object {
                        $fields += $_
                    }
                } else {
                    $fields = $nil
                }
                if ($c.group -ne $nil) {
                    if (-Not ($c.group -is [system.array])) {
                        $gs = @($c.group)
                    } else {
                        $gs = $c.group
                    }
                    $groups = @()
                    $gs | ForEach-Object {
                        $groups += $_
                    }
                } else {
                    $groups = $nil
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

function Build-Xml-Field()
{
    param($xml, $f)
    [System.Xml.XmlElement]$child = $xml.CreateElement("field")
    $attrName = $xml.CreateAttribute("name")
    $attrName.Value = $f.name
    $child.Attributes.Append($attrName) | Out-Null
    $attrReqd = $xml.CreateAttribute("required")
    $attrReqd.Value = $f.required
    $child.Attributes.Append($attrReqd) | Out-Null
    $child
}

function Build-Xml-Group()
{
    param($xml, $g)
    $child = $xml.CreateElement("group")
    $attrGroupName = $xml.CreateAttribute("name")
    $attrGroupName.Value = $g.name
    $child.Attributes.Append($attrGroupName) | Out-Null
    $attrGroupReqd = $xml.CreateAttribute("required")
    $attrGroupReqd.Value = $g.required
    $child.Attributes.Append($attrGroupReqd) | Out-Null
    if ($g.field -ne $nil) {
        if (-Not ($g.field -is [system.array])) {
            $gs = @($g.field)
        } else {
            $gs = $g.field
        }
        $gs | ForEach-Object {
            [System.Xml.XmlElement]$childField = Build-Xml-Field $xml $_
            $child.AppendChild($childField) | Out-Null
        }
    }
    Expand-Components $xml $g | Out-Null
    $child
}

function Process-Field() {
    param($xml, $attr)
    $child = $xml.CreateElement("field")
    $attrName = $xml.CreateAttribute("name")
    $attrName.Value = $attr.Get_Item("name")
    $child.Attributes.Append($attrName) | Out-Null
    $attrReqd = $xml.CreateAttribute("required")
    $attrReqd.Value = $attr.Get_Item("required")
    $child.Attributes.Append($attrReqd) | Out-Null
    $child
}

function Process-Group() {
    param($xml, $attr, $children)
    # TODO may contain a component
}

function Process-Component() {
    param($xml, $attr, $fields, $groups)
    $name = $attr.Get_Item("name")
    $set = $components.Get_Item($name)
    if ($set.fields -ne $nil) {
        $set.fields | ForEach-Object {
            $fields += Build-Xml-Field $xml $_
        }
    }
    if ($set.groups -ne $nil) {
        $set.groups | ForEach-Object {
            $groups += Build-Xml-Group $xml $_
        }
    }
}

function Expand-Components()
{
    param($xml, $m)

    $fields = @()
    $groups = @()

    $m.ChildNodes | ForEach-Object {
        $tag = $_.LocalName
        $attr = @{}
        $_.Attributes | ForEach-Object {
            $name = $_.Name
            $val = $_.Value
            $attr.Add($name, $val) | Out-Null
        }
        if ($tag -eq "field") {
            $fields += Process-Field $xml $attr
        }
        if ($tag -eq "group") {
            $groups += Process-Group $xml $attr $_.ChildNodes
        }
        if ($tag -eq "component") {
            Process-Component $xml $attr $fields $groups | Out-Null
        }
    }

    # TODO recombine

    return
    # expand components
    if ($m.component -ne $nil) {
        if (-Not ($m.component -is [system.array])) {
            $cs = @( $m.component )
        } else {
            $cs = $m.component
        }
        $cs | ForEach-Object {
            $c = $_
            $set = $components.Get_Item($c.name)
            if ($set.fields -ne $nil) {
                $set.fields | ForEach-Object {
                    $child = Build-Xml-Field $xml $_
                    $m.AppendChild($child) | Out-Null
                }
            }
            if ($set.groups -ne $nil) {
                $set.groups | ForEach-Object {
                    $child = Build-Xml-Group $xml $_
                    $m.AppendChild($child) | Out-Null
                }
            }
        }
    }
    # recursively expand groups' components
    if ($m.group -ne $nil) {
        if (-Not ($m.group -is [system.array])) {
            $gs = @($m.group)
        } else {
            $gs = $m.group
        }
        $gs | ForEach-Object {
            Expand-Components $xml $_ | Out-Null
        }
    }
}

# expand components in DD
function Get-Data-Dictionary() {
    param($xml)
    $dd = $xml.fix
    $components = Load-Components $dd
    $d = @{}
    $dd.messages.message | ForEach-Object {
        $m = $_
        $m = Expand-Components $xml $m | Out-Null
    }
    #Write-Host "done with $($dd.major).$($dd.minor)"
    $dd
}
