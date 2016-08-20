using System;
using System.Linq;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace JoarOyen.ReSharper.LiveTemplate.Macro
{
    public abstract class QuickParameterlessMacro : SimpleMacroImplementation
    {
        public abstract string QuickEvaluate(string value);

        public override string EvaluateQuickResult(IHotspotContext context)
        {
            var hotspotToEvaluate =
                from hotspot in context.HotspotSession.Hotspots
                from rangeMarker in hotspot.RangeMarkers
                where rangeMarker.DocumentRange == context.ExpressionRange
                select QuickEvaluate(HotspotValue(hotspot));
            
            return hotspotToEvaluate.FirstOrDefault();
        }

        public override bool HandleExpansion(IHotspotContext context)
        {
            context.HotspotSession.HotspotUpdated += HotspotSessionHotspotUpdated;

            return false;
        }

        private void HotspotSessionHotspotUpdated(object sender, EventArgs e)
        {
            var hotspotSession = (IHotspotSession)sender;
            hotspotSession.CurrentHotspot.QuickEvaluate();
        }

        private string HotspotValue(Hotspot hotspot)
        {
            return string.IsNullOrEmpty(hotspot.CurrentValue) ? hotspot.Name : hotspot.CurrentValue;
        }
    }
}
