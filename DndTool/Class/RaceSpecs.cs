using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class RaceSpecs
    {
        private Race race;
        private int vd;
        private String avgHeight;
        private String avgWidth;
        private List<SkillBonus> bonus;
        private List<Language> languages;
        private Vision vision;

        public RaceSpecs(Race race, int vd, string avgHeight, string avgWidth, List<SkillBonus> bonus, List<Language> languages, Vision vision)
        {
            this.race = race;
            this.vd = vd;
            this.avgHeight = avgHeight;
            this.avgWidth = avgWidth;
            this.bonus = bonus;
            this.languages = languages;
            this.vision = vision;
        }
    }
}
