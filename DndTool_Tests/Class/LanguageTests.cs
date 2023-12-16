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
    public class LanguageTests
    {
        [TestMethod()]
        public void T_Class_Language_InitValid()
        {
            List<Race> races = new List<Race>();
            Race race = new Race("test");

            races.Add(race);
            Language lang = new Language("Test", races, "Test");

            Assert.IsNotNull(lang);
        }

        [TestMethod()]
        public void T_Class_Language_InitEmptyRace()
        {
            List<Race> races = new List<Race>();

            Language lang = new Language("Test", races, "Test");

            Assert.IsNotNull(lang);
        }

        [TestMethod()]
        public void T_Class_Language_InitEmptyValues()
        {
            List<Race> races = new List<Race>();
            Language lang = new Language("", races, "");

            Assert.IsNotNull(lang);
        }

        [TestMethod()]
        public void T_Class_Language_GetName_Valid()
        {
            String name = "Test";
            List<Race> races = new List<Race>();
            Language lang = new Language("Test", races, "");

            Assert.AreEqual(lang.GetName(),name);
        }

        [TestMethod()]
        public void T_Class_Language_GetName_EmptyName()
        {
            String name = "";
            List<Race> races = new List<Race>();
            Language lang = new Language("", races, "");

            Assert.AreEqual(lang.GetName(), name);
        }

        [TestMethod()]
        public void T_Class_Language_GetDefaultRaces_Valid()
        {
            String name = "TestRace";
            List<Race> races = new List<Race>();
            Race race = new Race("TestRace");

            races.Add(race);
            Language lang = new Language("Test", races, "Test");

            Assert.AreEqual(lang.GetDefaultRaces(), name);
        }

        [TestMethod()]
        public void T_Class_Language_GetDefaultRaces_Empty()
        {
            String name = "";
            List<Race> races = new List<Race>();
            Language lang = new Language("Test", races, "Test");

            Assert.AreEqual(lang.GetDefaultRaces(), name);
        }

        [TestMethod()]
        public void T_Class_Language_GetWriting_Valid()
        {
            String name = "Test";
            List<Race> races = new List<Race>();
            Language lang = new Language("Test", races, "Test");

            Assert.AreEqual(lang.GetWriting(), name);
        }

        [TestMethod()]
        public void T_Class_Language_GetWriting_Empty()
        {
            String name = "";
            List<Race> races = new List<Race>();
            Language lang = new Language("Test", races, "");

            Assert.AreEqual(lang.GetWriting(), name);
        }
    }
}