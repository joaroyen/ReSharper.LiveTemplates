param([string]$configuration = 'Release')

. "$env:DevEnvDir\..\..\MSBuild\Current\Bin\MSBuild.exe" .\ReSharper.LiveTemplates.sln /p:Configuration=$configuration

pushd Extensions

nuget pack JoarOyen.ReSharper.LiveTemplates.nuspec -Prop Configuration=$configuration

popd
