#$scriptpath = Get-Location
#Set-Location -Path $scriptpath

cd ..\generation
ClangSharpPInvokeGenerator "@generate.windows.rsp"
ClangSharpPInvokeGenerator "@generate.unix.rsp"