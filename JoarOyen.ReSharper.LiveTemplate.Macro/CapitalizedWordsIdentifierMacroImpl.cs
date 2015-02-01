using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace JoarOyen.ReSharper.LiveTemplate.Macro
{
    [MacroImplementation(Definition = typeof(CapitalizedWordsIdentifierMacro))]
    public class CapitalizedWordsIdentifierMacroImpl : QuickParameterlessMacro
    {
        public override string QuickEvaluate(string value)
        {
            var identifierBuilder = new IdentifierBuilder(value);
            identifierBuilder.TransformToValidIdentifier();
            identifierBuilder.CapitalizeFirstCharacterInEveryWord();
            return identifierBuilder.ToString();
        } 
    }
}