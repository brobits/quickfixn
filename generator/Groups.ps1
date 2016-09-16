. "generator/Utility.ps1"

[string]$groupTemplate = Load-Template generator/templates/Group.cst 3

function Build-Group-Definitions()
{
    param($o)
    $definitions = @()
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
            $definitions += Build-Group-Definition $_
        }
    }
    Join-Lines $definitions
}

function Build-Group-Definition()
{
    param($g)
    $groupName = [string]::Format("{0}Group", $g.name)
    $countFieldName = $g.name
    $firstFieldName = $g.field[0].name
    $fieldSet = @()
    $g.field | ForEach-Object {
        $f = $_
        $fieldSet += [string]::Format("Tags.{0}", $f.name)
    }

    $fieldList = $fieldSet -join ", "

    # group fields
    $groupFields = Build-Message-Fields $g

    # child groups
    $childSet = @()
    $groups = @()
    if ($g.group -ne $null) {
        if ($g.group.Count -gt 0) {
            $groups = $g.group
        } else {
            $groups += $g.group
        }
    }
    if ($groups.Count -gt 0) {
        $groups | ForEach-Object {
            $childSet += Build-Group-Definition $_
        }
    }
    $childGroups = Join-Lines $childSet

    # substitute templates
    $template = $groupTemplate -replace "<#countFieldName#>", $countFieldName
    $template = $template -replace "<#firstFieldName#>", $firstFieldName
    $template = $template -replace "<#groupName#>", $groupName
    $template = $template -replace "<#fieldList#>", $fieldList
    $template = $template -replace "<#groupFields#>", $groupFields
    $template = $template -replace "<#childGroups#>", $childGroups

    $template
}
