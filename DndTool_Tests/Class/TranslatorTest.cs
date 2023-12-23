using DndTool.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DndTool_Tests.Class
{
    [TestClass()]
    public class TranslatorTest
    {
        [TestMethod()]
        public void Translate_Loaded()
        {
            // Arrange
            
            // Act
            Translator translator = new Translator();

            // Assert
            Assert.IsNotNull(translator);
        }

        [TestMethod()]
        public void Translate_ValidKey()
        {
            // Arrange
            Translator translator = new Translator();
            string key = "Humains";
            string language = "EN";

            // Act
            string result = translator.Translate(key, language);

            // Assert
            Assert.AreEqual("Humains", result);
        }

        [TestMethod()]
        public void Translate_InvalidLanguage()
        {
            // Arrange
            Translator translator = new Translator();
            string key = "Commun";
            string language = "InvalidLanguage";

            // Act
            string result = translator.Translate(key, language);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void Translate_ReturnsOriginalKey()
        {
            // Arrange
            var translator = new Translator();

            // Act
            var translation = translator.Translate("Commun", null);

            // Assert
            Assert.AreEqual("Commun", translation);
        }


        [TestMethod()]
        public void AddTranslations_AddsTranslationsToDictionary()
        {
            // Arrange
            var translator = new Translator();

            // Act
            translator.AddTranslations("TestCategory", new Dictionary<string, string> { { "Key1", "Value1" } });

            // Assert
            var translation = translator.Translate("Key1", "TestCategory");
            Assert.AreEqual("Key1", translation);
        }
    }
}
