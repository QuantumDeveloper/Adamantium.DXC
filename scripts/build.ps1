#$scriptpath = Get-Location
#Set-Location -Path $scriptpath

cd ..\generation
ClangSharpPInvokeGenerator "@generate.rsp"