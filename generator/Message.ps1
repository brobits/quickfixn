. "generator/Utility.ps1"

[string]$messageBaseTemplate = Load-Template generator/templates/MessageBase.cst 0

# generates a FIX specification's base Message class
function Generate-Message-Class()
{
  param($dd)
  [string]$fixVersion = $dd["version"]
  [string]$code = $messageBaseTemplate -replace "<#version#>", $fixVersion
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/Message.cs", $fixVersion)
  Write-Code $path $code
}
