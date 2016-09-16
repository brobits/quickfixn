. "generator/Specification.ps1"

$specPath = [string]"spec/tmp/" #[string]"spec/fix/"

Get-ChildItem $specPath | ForEach-Object {
  [xml]$xml = Get-Content -Path $specPath$_
  Generate-Specification $xml
}
