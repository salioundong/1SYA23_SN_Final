using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndTool.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndTool.Class;

namespace DndTool.Factory.Tests
{
    [TestClass()]
    public class GFactoryTests
    {
        GFactory factory = new GFactory();

        [TestMethod()]
        public void InitializeLanguages_NotEmpty()
        {
            List<Language> languages = factory.InitializeLanguages();
            Assert.IsTrue(languages.Count() > 0);
        }

        [TestMethod()]
        public void InitializeSkills_NotEmpty()
        {
            List<Skill> skills = factory.InitializeSkills();
            Assert.IsTrue(skills.Count() > 0);
        }

        [TestMethod()]
        public void InitializeVisions_NotEmpty()
        {
            List<Vision> visions = factory.InitializeVisions();
            Assert.IsTrue(visions.Count() > 0);
        }

        [TestMethod()]
        public void GetLanguages_NotEmpty()
        {
            List<Language> languages = factory.GetLanguages();
            Assert.IsTrue(languages.Count() > 0);
        }

        [TestMethod()]
        public void GetSkills_NotEmpty()
        {
            List<Skill> skills = factory.GetSkills();
            Assert.IsTrue(skills.Count() > 0);
        }

        [TestMethod()]
        public void GetVisions_NotEmpty()
        {
            List<Vision> visions = factory.GetVisions();
            Assert.IsTrue(visions.Count() > 0);
        }

        //-------- ExecuteCommand --------

        [TestMethod()]
        public void ExecuteCommand_OnlyCommand()
        {
            String[] inputs = {""};
            factory.ExecuteCommand("help", inputs);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExecuteCommand_helpExtra()
        {
            String[] inputs = { "test", "test2" };
            factory.ExecuteCommand("help", inputs);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExecuteCommand_vLang()
        {
            String[] inputs = { "test" };
            factory.ExecuteCommand("vLang", inputs);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExecuteCommand_vSkills()
        {
            String[] inputs = { "test" };
            factory.ExecuteCommand("vSkills", inputs);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExecuteCommand_vVision()
        {
            String[] inputs = { "test" };
            factory.ExecuteCommand("vVision", inputs);
            Assert.IsTrue(true);
        }

        //-------- RequestCommand --------
        [TestMethod()]
        public void RequestCommand_Empty()
        {
            String input = "";
            String commandReceived = "";
            String commandExpected = "";

            commandReceived = factory.RequestCommand(input);
            Assert.AreEqual(commandReceived, commandExpected);
        }

        [TestMethod()]
        public void RequestCommand_helpWithExtra()
        {
            String input = "help v test";
            String commandReceived = "";
            String commandExpected = "help";

            commandReceived = factory.RequestCommand(input);
            Assert.AreEqual(commandReceived, commandExpected);
        }

        [TestMethod()]
        public void RequestCommand_Unknown()
        {
            String input = "test 2 fda";
            String commandReceived = "";
            String commandExpected = "test";

            commandReceived = factory.RequestCommand(input);
            Assert.AreEqual(commandReceived, commandExpected);
        }

        [TestMethod()]
        public void RequestCommand_vLang()
        {
            String input = "vLang 2 fda";
            String commandReceived = "";
            String commandExpected = "vLang";

            commandReceived = factory.RequestCommand(input);
            Assert.AreEqual(commandReceived, commandExpected);
        }

        [TestMethod()]
        public void RequestCommand_vSkillsNoExtra()
        {
            String input = "vSkills";
            String commandReceived = "";
            String commandExpected = "vSkills";

            commandReceived = factory.RequestCommand(input);
            Assert.AreEqual(commandReceived, commandExpected);
        }
    }
}