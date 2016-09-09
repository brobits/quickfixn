. "generator/Utility.ps1"

# generates a FIX specification's base Message class
function Generate-Message-Class()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template generator/templates/Message.cst 0
  [string]$code = $template -replace "<#version#>", $fixVersion
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/Message.cs", $fixVersion)
  Write-Code $path $code
}
