using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JoarOyen.ReSharper.LiveTemplate.Macro.Properties;

namespace JoarOyen.ReSharper.LiveTemplate.Macro
{
    [MacroDefinition(
        "JoarOyenLiveTemplateMacros.CapitalizedWordsIdentifier", 
        ResourceType = typeof(Resources),
        DescriptionResourceName = nameof(Resources.CapitalizedWordsIdentifierDescription),
        LongDescriptionResourceName = nameof(Resources.CapitalizedWordsIdentifierLongDescription))]
    public class CapitalizedWordsIdentifierMacro : SimpleMacroDefinition
    {
    }
}