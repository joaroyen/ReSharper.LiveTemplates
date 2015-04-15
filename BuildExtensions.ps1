param([string]$configuration = 'Release')

msbuild .\ReSharper.LiveTemplates.sln /p:Configuration=$configuration

pushd Extensions

nuget pack JoarOyen.ReSharper.LiveTemplates.nuspec -Prop Configuration=$configuration

popd
