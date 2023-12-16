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
    public class VisionTests
    {
        [TestMethod()]
        public void T_Class_VisionInit_Loaded()
        {
            //Arrange

            //Act
            Vision vision = new Vision("test");

            //Assert
            Assert.IsNotNull(vision);
        }

        [TestMethod()]
        public void T_Class_VisionInit_EmptyInit()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsNotNull(new Vision("")); // Je vous montre que c'est possible, mais ne respecte pas le AAA = Dépend de la rigidité que l'équipe valorise
        }

        [TestMethod()]
        public void T_ClassVision_GetName_EmptyName()
        {
            //Arrange
            String name = "";
            String visionName;

            //Act
            Vision vision = new Vision("");
            visionName = vision.GetName();

            //Assert
            Assert.AreEqual(name, visionName);
        }

        [TestMethod()]
        public void T_ClassVision_GetName_NameOutput()
        {
            //Arrange
            String name = "Test";
            String visionName;

            //Act
            Vision vision = new Vision("Test");
            visionName = vision.GetName();

            //Assert
            Assert.AreEqual(name, visionName);
        }
    }
}