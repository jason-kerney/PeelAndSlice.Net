# To run this script directly, open PowerShell and run this command:
#     PS> Invoke-WebRequest -UseBasicParsing https://raw.githubusercontent.com/refactoring-pipelines/Pipelines/master/machine-setup.ps1 | Invoke-Expression

#Requires -RunAsAdministrator

iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/windows.ps1 | iex
iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/visual-studio.ps1 | iex

cinst dotnetcore-2.1-runtime

"C:\Program Files\Git\cmd\git.exe" clone https://github.com/refactoring-pipelines/Pipelines.git C:\Source\Pipelines
github C:\Source\Pipelines
