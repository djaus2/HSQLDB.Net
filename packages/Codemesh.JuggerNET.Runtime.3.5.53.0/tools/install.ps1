param($installPath, $toolsPath, $package, $project)

foreach($prop in $project.Properties)
{
    if( $prop.Name -eq "PostBuildEvent")
    {
        $val = $prop.Value
        $copyStmt = 'xcopy /D "' + $installPath + '\native\$(PlatformName)\xmogrt.dll" "$(TargetDir)"'
        if( ($val.Length -eq 0) -or (($val -contains "xmogrt.dll") -and ( ($val -split ("`n")).Length -eq 1 ) ) )
        {
            $prop.Value = $copyStmt
            write-host "Created PostBuildEvent"
        }
        else
        {
            $prop.Value = ( $val + "`r`n" + $copyStmt )
            write-host "Appended PostBuildEvent"
        }
        
        $anyCpu = Join-Path $installPath '\native\AnyCPU'
        $pa6432 = (Get-Process -id $PID).StartInfo.EnvironmentVariables["PROCESSOR_ARCHITEW6432"]
        
        if( !(Test-Path $anyCpu) )
        {
            if( "AMD64" -eq $pa6432 ) 
            {
                if( Test-Path (Join-Path $installPath '\native\x64') )
                {
                    Copy-Item (Join-Path $installPath '\native\x64') -Destination $anyCpu -Recurse
                }
                write-host 'Defaulted "Any CPU" configurations to use AMD64 native runtime (requires a 64-bit JVM)'
            }
            elseif( "X86" -eq $pa6432 )
            {
                if( Test-Path (Join-Path $installPath '\native\x86') )
                {
                    Copy-Item (Join-Path $installPath '\native\x86') -Destination $anyCpu -Recurse
                }
                write-host 'Defaulted "Any CPU" configurations to use X86 native runtime (requires a 32-bit JVM)'
            }
            else 
            {
                if( Test-Path (Join-Path $installPath '\native\x86') )
                {
                    Copy-Item (Join-Path $installPath '\native\x86') -Destination $anyCpu -Recurse
                }
                write-host 'Defaulted "Any CPU" configurations to use X86 native runtime (requires a 32-bit JVM)'
            }
        }
        break
    }
}
