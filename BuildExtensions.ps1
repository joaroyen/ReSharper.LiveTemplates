param([string]$configuration = 'Release')

dotnet build --configuration $configuration

pushd Extensions

nuget pack JoarOyen.ReSharper.LiveTemplates.nuspec -Prop Configuration=$configuration

popd
