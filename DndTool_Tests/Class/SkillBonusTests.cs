using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndTool.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class.Tests
{
    [TestClass()]
    public class SkillBonusTests
    {
        [TestMethod()]
        public void T_Class_SkillBonusInit_Loaded()
        {
            Skill skill = new Skill("test");
            SkillBonus  skillB = new SkillBonus(skill, 2);

            Assert.IsNotNull(skillB);
        }

        [TestMethod()]
        public void T_Class_SkillBonusInit_EmptyInit()
        {
            Skill skill = new Skill("");
            SkillBonus skillB = new SkillBonus(skill, 2);

            Assert.IsNotNull(skillB);
        }

        [TestMethod()]
        public void T_Class_SkillBonusInit_bonus0()
        {
            Skill skill = new Skill("");
            SkillBonus skillB = new SkillBonus(skill, 0);

            Assert.IsNotNull(skillB);
        }

        [TestMethod()]
        public void T_Class_SkillBonusInit_bonusNeg()
        {
            Skill skill = new Skill("");
            SkillBonus skillB = new SkillBonus(skill, -2);

            Assert.IsNotNull(skillB);
        }

        [TestMethod()]
        public void T_ClassSkillBonus_GetName_EmptyName()
        {
            String name = "";
            String skillName;

            Skill skill = new Skill("");
            SkillBonus skillB = new SkillBonus(skill, 2);
            skillName = skillB.GetSkill();

            Assert.AreEqual(name, skillName);
        }

        [TestMethod()]
        public void T_ClassSkillBonus_GetName_NameOutput()
        {
            String name = "Test";
            String skillName;

            Skill skill = new Skill("Test");
            SkillBonus skillB = new SkillBonus(skill, 2);
            skillName = skillB.GetSkill();

            Assert.AreEqual(name, skillName);
        }

        [TestMethod()]
        public void T_ClassSkillBonus_GetBonus_Output()
        {
            int bonus = 4;
            int skillBonus;

            Skill skill = new Skill("Test");
            SkillBonus skillB = new SkillBonus(skill, 4);
            skillBonus = skillB.GetBonus();

            Assert.AreEqual(bonus, skillBonus);
        }
    }
}