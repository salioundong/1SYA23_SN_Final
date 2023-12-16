using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class SkillBonus
    {
        public Skill skill;
        public int bonus;

        public SkillBonus(Skill skill, int bonus)
        {
            this.skill = skill;
            this.bonus = bonus;
        }

        public String GetSkill()
        {
            return this.skill.GetName();
        }

        public int GetBonus() 
        {
            return this.bonus;
        }
    }
}
