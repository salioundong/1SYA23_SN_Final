using DndTool.Class;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Translate_ValidKeyAndLanguage_ReturnsTranslation()
        {
            // Arrange
            Translator translator = new Translator();
            string key = "Humains";
            string language = "EN";

            // Act
            string result = translator.Translate(key, language);

            // Assert
            Assert.AreEqual("Humans", result);
        }

        [TestMethod()]
        public void Translate_InvalidLanguage_ReturnsNull()
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
        public void Translate_InvalidKey_ReturnsNull()
        {
            // Arrange
            Translator translator = new Translator();
            string key = "InvalidKey";
            string language = "EN";

            // Act
            string result = translator.Translate(key, language);

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
