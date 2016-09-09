. "generator/Utility.ps1"

# generates all Message classes for a FIX specification
function Generate-Message-Classes()
{
    param($dd)
    [string]$fixVersion = Fix-Version $dd
    [string]$template = Load-Template generator/templates/Message.cst 0
    [string]$code = $template -replace "<#version#>", $fixVersion
    $out = @()
    $dd.messages.message | ForEach-Object {
        $m = $_
        $msgTemplate = $template -replace "<#msgName#>", $m.name
        $msgTemplate = $msgTemplate -replace "<#msgType#>", $m.msgtype
        $msgTemplate = $msgTemplate -replace "<#version#>", $fixVersion
        $msgTemplate = $msgTemplate -replace "<#msgConstructorArguments#>", (Build-Constructor-Arguments $m)
        $msgTemplate = $msgTemplate -replace "<#msgConstructorAssignments#>", (Build-Constructor-Assignments $m)
        $msgTemplate = $msgTemplate -replace "<#msgFields#>", (Build-Message-Fields $m)
        $msgTemplate = $msgTemplate -replace "<#msgGroups#>", (Build-Message-Groups $m)
        [string]$path = [string]::Format("QuickFIXn/Message/{0}/{1}.cs", $fixVersion, $m.name)
        Write-Code $path $msgTemplate
    }
}

function Build-Constructor-Arguments()
{
    param($m)
    $arguments = @()
    $m.field | ForEach-Object {
        $f = $_
        if ($f.required -eq "Y") {
            [string]$id = [string]::Format("a{0}", $f.name)
            [string]$arg = [string]::Format("QuickFix.Fields.{0} {1}", $f.name, $id);
            $arguments += $arg
        }
    }
    $delimiterTabs = Tabinate-Line "" 5
    $leadingTabs = Tabinate-Line "" 4
    $arglist = $arguments -join [string]::Format(",`n{0}", $delimiterTabs)
    [string]::Format("`n{0}{1}`n{2}", $delimiterTabs, $arglist, $leadingTabs)
}

function Build-Constructor-Assignments()
{
    param($m)
    $assignments = @()
    $m.field | ForEach-Object {
        $f = $_
        if ($f.required -eq "Y") {
            [string]$id = [string]::Format("a{0}", $f.name)
            [string]$assignment = [string]::Format("this.{0} = {1};", $f.name, $id);
            $assignments += $assignment
        }
    }
    $tabs = Tabinate-Lines $assignments 4
    Join-Lines $tabs
}

function Build-Message-Fields()
{
    param($m)
}

function Build-Message-Groups()
{
    param($m)
}
