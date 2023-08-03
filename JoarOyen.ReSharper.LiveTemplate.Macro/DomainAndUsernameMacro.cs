using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JoarOyen.ReSharper.LiveTemplate.Macro.Properties;

namespace JoarOyen.ReSharper.LiveTemplate.Macro
{
    [MacroDefinition(
        "JoarOyenLiveTemplateMacros.DomainAndUsername",
        ResourceType = typeof(Resources),
        DescriptionResourceName = nameof(Resources.DomainAndUsernameDescription),
        LongDescriptionResourceName = nameof(Resources.DomainAndUsernameLongDescription))]
    public class DomainAndUsernameMacro : SimpleMacroDefinition
    {
    }
}