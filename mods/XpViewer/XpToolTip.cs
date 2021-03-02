using StardewValley;
using StardewValley.Menus;
using System;

namespace XpViewer
{
    public class XpToolTip
    {
        /// <summary> Total xp required to get to a skill level </summary>
        private static readonly int[] XpForLevel = {
           /*  1 */ 100,
           /*  2 */ 380,
           /*  3 */ 770,
           /*  4 */ 1800,
           /*  5 */ 2150,
           /*  6 */ 3300,
           /*  7 */ 4800,
           /*  8 */ 6900,
           /*  9 */ 10000,
           /* 10 */ 15000,
        };

        public static void SetSkillXpToolTip(GameMenu menu)
        {
            SkillsPage skillPage = menu.pages[GameMenu.skillsTab] as SkillsPage;
            foreach (ClickableTextureComponent component in skillPage.skillAreas)
                if (int.TryParse(component.name, out int skillIndex))
                    component.hoverText = GetXpForSkillstring(skillIndex);
        }

        private static string GetXpForSkillstring(int skillIndex)
        {
            Tuple<int, int> XP = GetXpForSkill(skillIndex);
            return $"{XP.Item1}/{XP.Item2}";
        }

        private static Tuple<int, int> GetXpForSkill(int skillIndex)
        {
            return new Tuple<int, int>(Game1.player.experiencePoints[skillIndex], XpForLevel[Game1.player.GetSkillLevel(skillIndex)]);
        }
    }
}
