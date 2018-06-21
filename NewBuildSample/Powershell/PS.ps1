$envVars = Get-ChildItem env: | sort name

ForEach ($item in $envVars.GetEnumerator())
{
    Write-Output "$($item.Key)=$($item.Value)"
}


$cwd = get-location

Write-Host "Current Working Folder = $cwd"

Write-Host "********Remove Test Environment Variable Created by CmdScript task********"
Remove-Item Env:\TESTENVRIONMENTVARIABLE
