using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JoarOyen.ReSharper.LiveTemplate.Macro.Properties;

namespace JoarOyen.ReSharper.LiveTemplate.Macro
{
    [MacroDefinition(
        "JoarOyenLiveTemplateMacros.ValidIdentifier",
        ResourceType = typeof(Resources),
        DescriptionResourceName = nameof(Resources.ValidIdentifierDescription),
        LongDescriptionResourceName = nameof(Resources.ValidIdentifierLongDescription))]
    public class ValidIdentifierMacro : SimpleMacroDefinition
    {
    }
}