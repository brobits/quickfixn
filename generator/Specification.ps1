# see: http://stackoverflow.com/questions/29147715/make-visualstudio-run-a-command-to-generate-c-sharp-code
. "generator/Utility.ps1"

function Generate-Message-Class()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/Message.cst 0
  [string]$code = $template -replace "<%version%>", $fixVersion
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/Message.cs", $fixVersion)
  Write-Code $path $code
}

function Generate-Message-Type-Cases()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  $cases = @()
  $dd.messages.message | ForEach-Object {
    [string]$msgName = $_.name
    $case = [string]::Format("case QuickFix.{0}.{1}.MsgType: return new QuickFix.{0}.{1}();", $fixVersion, $msgName)
    $out = Tabinate $case 5
    $cases += Join-Lines $out
  }
  Join-Lines $cases
}

function Build-Group-Cases()
{
    param([string]$fixVersion, [string]$namespace, $o)
    $cases = @()
    $groups = @()
    if ($o.group -ne $null) {
      if ($o.group.Count -gt 0) {
        $groups = $o.group
      } else {
        $groups += $o.group
      }
    }
    if ($groups.Count -gt 0) {
      $groups | ForEach-Object {
        $g = $_
        $case = [string]::Format("case QuickFix.Fields.Tags.{2}: return new QuickFix.{0}.{1}.{2}Group();", $fixVersion, $namespace, $g.name)
        $cases += $case
        $recursiveNamespace = [string]::Format("{0}.{1}Group", $namespace, $g.name)
        $r = Build-Group-Cases $fixVersion $recursiveNamespace $g
        if ($r.Count -gt 0) {
            $cases += $r
        }
      }
    }
    $cases
}

function Generate-Message-Groups()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/MessageGroup.cst 4
  $template = $template -replace "<#version#>", $fixVersion
  $out = @()
  $dd.messages.message | ForEach-Object {
    $cases = Build-Group-Cases $fixVersion $_.name $_
    if ($cases.Count -gt 0) {
        $msgTemplate = $template -replace "<#msgName#>", $_.name
        $out += ($msgTemplate -replace "<#msgGroupCases#>", (Join-Lines (Tabinate $cases 6)))
        $out += ""
    }
  }
  Join-Lines $out
}

function Generate-MessageFactory-Class()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/MessageFactory.cst 0
  [string]$code = $template -replace "<#version#>", $fixVersion
  $msgTypeCases = Generate-Message-Type-Cases $dd
  [string]$code = $code -replace "<#msgTypeCases#>", $msgTypeCases
  $createMsgGroups = Generate-Message-Groups $dd
  [string]$code = $code -replace "<#createMessageGroups#>", $createMsgGroups
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/MessageFactory.cs", $fixVersion)
  Write-Code $path $code
}

function Generate-Message-Classes()
{

}

function Generate-Specification()
{
  param($dataDictionary)
  Generate-Message-Class $dataDictionary
  Generate-MessageFactory-Class $dataDictionary
}
