param (
    [string] $fileName
)

$result = Get-ChildItem -Path ${env:agent_releasedirectory} -Filter $fileName -Recurse
if(-Not $result)
{
throw
}