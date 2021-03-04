using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using StardewValley;
using Microsoft.Xna.Framework.Graphics;

namespace AreaOverlay
{
    abstract class ObjectWithArea
    {
        public Object Obj { get; set; }
        public abstract IEnumerable<Vector2> GetTilesInArea();

        public static ObjectWithArea MakeObjectWithArea(Object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o.IsSprinkler())
            {
                return new SprinklerHolder(o);
            }
            else if (o.bigCraftable && o.Name.Contains("arecrow"))
            {
                return new ScareCrowHolder(o);
            }
            else
            {
                return null;
            }
        }
    }

    class SprinklerHolder : ObjectWithArea
    {
        public SprinklerHolder(Object obj) => Obj = obj;

        public override IEnumerable<Vector2> GetTilesInArea()
        {
            return Obj.GetSprinklerTiles();
        }
    }

    class ScareCrowHolder : ObjectWithArea
    {
        public ScareCrowHolder(Object obj) => Obj = obj;

        public override IEnumerable<Vector2> GetTilesInArea()
        {
            return (Obj.Name.Contains("Deluxe") ? ScarecrowRadius.DeluxeAffectedTile : ScarecrowRadius.AffectedTile).Select(tile => tile + Obj.TileLocation);
        }
    }

    internal class AreaOfEffectOverlay
    {
        public enum Selector
        {
            All,
            Scarecrow,
            Sprinkler,
            None,
        }

        private readonly Texture2D m_texture;
        private ObjectWithArea m_overedObject;
        private Selector m_currentSelection;

        static Dictionary<Selector, Color> m_colors;

        public AreaOfEffectOverlay(Texture2D t, AoeOverlayConfig config)
        {
            m_texture = t;
            m_colors = new Dictionary<Selector, Color>() {
                { Selector.All, config.MouseOverColor},
                { Selector.Scarecrow, config.ScarecrowColor},
                { Selector.Sprinkler, config.SprinklerColor},
            };

            m_currentSelection = config.DrawAreaDefaultValue ? Selector.All : Selector.None;
        }

        private bool ObjectTypeMatchSelector(ObjectWithArea obj, Selector selector)
        {
            switch (selector)
            {
                case Selector.Scarecrow:
                    return obj is ScareCrowHolder;

                case Selector.Sprinkler:
                    return obj is SprinklerHolder;

                default:
                    return false;
            }
        }

        public void SetItemToDraw(Object obj)
        {
            m_overedObject = ObjectWithArea.MakeObjectWithArea(obj);
        }

        public void ResetItemToDraw()
        {
            m_overedObject = null;
        }

        public void CycleSelector()
        {
            switch (m_currentSelection)
            {
                case Selector.All:
                    m_currentSelection = Selector.Scarecrow;
                    break;

                case Selector.Scarecrow:
                    m_currentSelection = Selector.Sprinkler;
                    break;
                
                case Selector.Sprinkler:
                    m_currentSelection = Selector.None;
                    break;
                
                case Selector.None:
                    m_currentSelection = Selector.All;
                    break;
            }
        }

        public void DrawAll(SpriteBatch b)
        {
            Dictionary<Selector, IEnumerable<ObjectWithArea>> objects = new Dictionary<Selector, IEnumerable<ObjectWithArea>>();
            IEnumerable<ObjectWithArea> items = GetItemsWithArea();

            foreach (Selector selector in System.Enum.GetValues(typeof(Selector)))
            {
                objects.Add(selector, items.Where(obj => ObjectTypeMatchSelector(obj, selector)));
            }

            foreach (var list in objects)
            {
                foreach (var item in list.Value)
                {
                    foreach (var tile in item.GetTilesInArea())
                    {
                        b.Draw(m_texture, PixelToTile(tile), m_colors[list.Key]);
                    }
                }
            }

            DrawOveredItem(b);
        }

        public void Draw(SpriteBatch b)
        {
            if (m_currentSelection == Selector.None)
            {
                DrawOveredItem(b);
                return;
            }
            
            if (m_currentSelection == Selector.All)
            {
                DrawAll(b);
                return;
            }

            foreach (var item in GetItemsWithArea().Where(obj => ObjectTypeMatchSelector(obj, m_currentSelection)))
            {
                foreach (var tile in item.GetTilesInArea())
                {
                    b.Draw(m_texture, PixelToTile(tile), m_colors[m_currentSelection]);
                }
            }

            DrawOveredItem(b);
        }

        public void DrawOveredItem(SpriteBatch b)
        {
            if (m_overedObject == null)
                return;

            foreach (var tile in m_overedObject.GetTilesInArea())
            {
                b.Draw(m_texture, PixelToTile(tile), m_colors[Selector.All]);
            }
        }

        private static Rectangle PixelToTile(Vector2 position)
        {
            int x = (int)(position.X * Game1.tileSize - Game1.viewport.X);
            int y = (int)(position.Y * Game1.tileSize - Game1.viewport.Y);
            return new Rectangle(x, y, Game1.tileSize, Game1.tileSize);
        }

        private IEnumerable<ObjectWithArea> GetItemsWithArea()
        {
            return Game1.player.currentLocation.objects.Pairs
                .Where(pair => IsScareCrow(pair.Value) || pair.Value.IsSprinkler())
                .Select(pair => ObjectWithArea.MakeObjectWithArea(pair.Value));
        }

        private static bool IsScareCrow(Object o)
        {
            return o.bigCraftable && o.Name.Contains("arecrow");
        }
    }
}
