# generates a FIX specification's QuickFIX source code
# see: http://stackoverflow.com/questions/29147715/make-visualstudio-run-a-command-to-generate-c-sharp-code
. "generator/Message.ps1"
. "generator/MessageFactory.ps1"
. "generator/Messages.ps1"

function Generate-Specification()
{
  param($xml)
  $dd = Get-Data-Dictionary $xml
  Generate-Message-Class $dd
  Generate-MessageFactory-Class $dd
  Generate-Message-Classes $dd
}
