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
    public class RaceTests
    {
        [TestMethod()]
        public void T_Class_RaceInit_Loaded()
        {
            Race race = new Race("test");

            Assert.IsNotNull(race);
        }

        [TestMethod()]
        public void T_Class_RaceInit_EmptyInit()
        {
            Race race = new Race("");

            Assert.IsNotNull(race);
        }

        [TestMethod()]
        public void T_ClassRace_GetName_EmptyName()
        {
            String name = "";
            String raceName;

            Race race = new Race("");
            raceName = race.GetName();

            Assert.AreEqual(name, raceName);
        }

        [TestMethod()]
        public void T_ClassRace_GetName_NameOutput()
        {
            String name = "Test";
            String raceName;

            Race race = new Race("Test");
            raceName = race.GetName();

            Assert.AreEqual(name, raceName);
        }
    }
}