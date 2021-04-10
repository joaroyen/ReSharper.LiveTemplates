param (
    [Parameter(Mandatory=$true)]
    [int]$year, 
    [Parameter(Mandatory=$true)]
    [int]$quarter
)

function ReplaceContent([string]$filePath, [string]$regExp, [string] $replace){
    (Get-Content $filePath) -replace $regExp, $replace | Set-Content $filePath -Encoding utf8BOM
}

ReplaceContent .\Directory.Build.props "Copyright © \d\d\d\d Joar Øyen" "Copyright © $year Joar Øyen"
ReplaceContent .\Directory.Build.props "<Version>\d\d\d\d.\d.0.0</Version>" "<Version>$year.$quarter.0.0</Version>"
ReplaceContent .\License.txt "Copyright \(c\) \d\d\d\d Joar Øyen" "Copyright (c) $year Joar Øyen"
ReplaceContent .\README.md "ReSharper \d\d\d\d.\d" "ReSharper $year.$quarter"
ReplaceContent .\Extensions\JoarOyen.ReSharper.LiveTemplates.nuspec "<version>\d\d\d\d\.\d.0</version>" "<version>$year.$quarter.0</version>"
ReplaceContent .\Extensions\JoarOyen.ReSharper.LiveTemplates.nuspec "ReSharper \d\d\d\d\.\d" "ReSharper $year.$quarter"
ReplaceContent .\Extensions\JoarOyen.ReSharper.LiveTemplates.nuspec "Copyright © \d\d\d\d Joar Øyen" "Copyright © $year Joar Øyen"
ReplaceContent .\Extensions\JoarOyen.ReSharper.LiveTemplates.nuspec "version=""\[\d\d\d.(\d)\]""" "version=""[$($year % 100)$quarter.`$1]"""
ReplaceContent .\JoarOyen.ReSharper.LiveTemplate.Macro\JoarOyen.ReSharper.LiveTemplate.Macro.csproj "Version=""\d\d\d\d.\d.0""" "Version=""$year.$quarter.0"""
ReplaceContent .\JoarOyen.ReSharper.LiveTemplate.Macro.Test.Unit\JoarOyen.ReSharper.LiveTemplate.Macro.Test.Unit.csproj "Version=""\d\d\d\d.\d.0""" "Version=""$year.$quarter.0"""
