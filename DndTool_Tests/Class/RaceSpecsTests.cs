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
    public class RaceSpecsTests
    {
        [TestMethod()]
        public void T_Class_RaceSpecs_Init()
        {
            Race race = new Race("");
            List<SkillBonus> skillBonus = new List<SkillBonus>();
            List<Language> languages = new List<Language>();
            Vision vision = new Vision("");

            RaceSpecs specs = new RaceSpecs(race, 6, "", "", skillBonus, languages, vision);

            Assert.IsNotNull(specs);
        }
    }
}