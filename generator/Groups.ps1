. "generator/Utility.ps1"

[string]$groupTemplate = Load-Template generator/templates/Group.cst 3

function Build-Group-Definitions()
{
    param($o)
    $definitions = @()
    $o["groups"] | ForEach-Object {
        $definitions += Build-Group-Definition $_
    }
    Join-Lines $definitions
}

function Build-Group-Definition()
{
    param($g)
    Write-Host "building group definition"
    $groupName = [string]::Format("{0}Group", $g["name"])
    $countFieldName = $g["name"]
    $firstFieldName = $g["fields"][0]["name"]
    $fieldSet = @()
    $g.fields | ForEach-Object {
        $f = $_
        $fieldSet += [string]::Format("Tags.{0}", $f["name"])
    }

    $fieldList = $fieldSet -join ", "

    # group fields
    $groupFields = Build-Message-Fields $g

    # child groups
    $childSet = @()
    $g.groups | ForEach-Object {
        $childSet += Build-Group-Definition $_
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
