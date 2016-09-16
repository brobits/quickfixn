[string]$messageFieldTemplate = Load-Template generator/templates/MessageField.cst 3

# TODO
function Build-Field() {
    param($f)
}

# TODO
function Build-Group() {
    param($g)
}

# TODO
function Build-Component() {
    param($c)
}

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
    $dd.components.component | ForEach-Object {
        $c = $_
        if (!$components.ContainsKey($c.name)) {
            $code = Build-Message-Fields $c
            $components.Add($c.name, $code)
        }
    }
    $components
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

# join an array of lines into a string
function Join-Lines()
{
  param($arr)
  [string]($arr -join "`n")
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
