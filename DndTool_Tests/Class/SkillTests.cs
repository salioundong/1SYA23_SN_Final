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
    public class SkillTests
    {
        [TestMethod()]
        public void T_Class_SkillInit_Loaded()
        {
            Skill skill = new Skill("test");

            Assert.IsNotNull(skill);
        }

        [TestMethod()]
        public void T_Class_SkillInit_EmptyInit()
        {
            Skill skill = new Skill("");

            Assert.IsNotNull(skill);
        }

        [TestMethod()]
        public void T_ClassSkill_GetName_EmptyName()
        {
            String name = "";
            String skillName;

            Skill skill = new Skill("");
            skillName = skill.GetName();

            Assert.AreEqual(name, skillName);
        }

        [TestMethod()]
        public void T_ClassSkill_GetName_NameOutput()
        {
            String name = "Test";
            String skillName;

            Skill skill = new Skill("Test");
            skillName = skill.GetName();

            Assert.AreEqual(name, skillName);
        }
    }
}