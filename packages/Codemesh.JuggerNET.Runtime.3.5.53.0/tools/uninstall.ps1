param($installPath, $toolsPath, $package, $project)

foreach($prop in $project.Properties)
{
    if( $prop.Name -eq "PostBuildEvent")
    {
        $val = $prop.Value
        $copyStmt = 'xcopy /D "' + $installPath + '\native\$(PlatformName)\xmogrt.dll" "$(TargetDir)"'
        if( ($val.Length -gt 0) -and ($val -eq $copyStmt) )
        {
            $prop.Value = ""
            write-host "Removed PostBuildEvent"
        }
        elseif( $val.Contains($copyStmt) )
        {
            $copyStmtEol = $copyStmt + "`r`n"
            if( $val.Contains($copyStmtEol) )
            {
                $val = $val.Replace( $copyStmtEol, "" )
            }
            else
            {
                $val = $val.Replace( $copyStmt, "" )
            }
            $prop.Value = $val
            write-host "Cleaned PostBuildEvent"
        }
    }
}
