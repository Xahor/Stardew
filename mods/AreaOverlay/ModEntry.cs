using Microsoft.Xna.Framework.Graphics;

using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;

namespace AreaOverlay
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        private bool m_doDrawMouseOver = false;
        private AreaOfEffectOverlay m_aoeOverlayManager;
        private AoeOverlayConfig m_aoeOverlayConfig;

        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            m_aoeOverlayConfig = helper.ReadConfig<AoeOverlayConfig>();

            m_aoeOverlayManager = new AreaOfEffectOverlay(helper.Content.Load<Texture2D>("assets/FilledTexture.png"), m_aoeOverlayConfig);
            m_doDrawMouseOver = m_aoeOverlayConfig.OnMouseOverDefaultValue;

            helper.Events.Input.ButtonPressed += OnButtonPressed;
            helper.Events.Input.CursorMoved += Input_CursorMoved;

            helper.Events.Display.RenderedWorld += Display_RenderedWorld;
        }

        /*********
        ** Private methods
        *********/

        private void Display_RenderedWorld(object sender, RenderedWorldEventArgs e)
        {
            m_aoeOverlayManager.Draw(e.SpriteBatch);
        }

        private void Input_CursorMoved(object sender, CursorMovedEventArgs e)
        {
            if (Context.IsWorldReady)
                m_aoeOverlayManager.SetItemToDraw(m_doDrawMouseOver ? Game1.currentLocation.getObjectAtTile((int)e.NewPosition.Tile.X, (int)e.NewPosition.Tile.Y) : null);
        }

        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;

            if (e.Button == m_aoeOverlayConfig.ToggleOnMouseOverKey)
            {
                m_doDrawMouseOver = !m_doDrawMouseOver;
            }
            else if (e.Button == m_aoeOverlayConfig.CycleItemKey)
            {
                m_aoeOverlayManager.CycleSelector();
            }
        }
    }
}