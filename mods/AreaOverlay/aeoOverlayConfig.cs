using Microsoft.Xna.Framework;
using StardewModdingAPI;

namespace AreaOverlay
{
    internal class AoeOverlayConfig
    {
        public bool DrawAreaDefaultValue { get; set; } = true;
        public bool OnMouseOverDefaultValue { get; set; } = true;
        
        public SButton CycleItemKey { get; set; } = SButton.F2;
        public SButton ToggleOnMouseOverKey { get; set; } = SButton.F3;

        public Color SprinklerColor { get; set; } = new Color(0, 0, 255, 255);
        public Color ScarecrowColor { get; set; } = new Color(255, 255, 255, 255);
        public Color MouseOverColor { get; set; } = new Color(0, 0, 0, 255);
    }
}