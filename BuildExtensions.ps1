msbuild .\ReSharper.LiveTemplates.sln /p:Configuration=Release

pushd Extensions

nuget pack JoarOyen.ReSharper.LiveTemplates.nuspec

popd
