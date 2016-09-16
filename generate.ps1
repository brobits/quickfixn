. "generator/Specification.ps1"

$specPath = [string]"spec/fix/"

Get-ChildItem $specPath | ForEach-Object {
  [xml]$xml = Get-Content -Path $specPath$_
  $dataDictionary = $xml.fix
  Generate-Specification $dataDictionary
}
