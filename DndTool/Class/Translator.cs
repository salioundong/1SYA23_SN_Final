using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class Translator : ITranslation
    {
        private Dictionary<string, Dictionary<string, string>> translations;

        public Translator()
        {
            translations = new Dictionary<string, Dictionary<string, string>>();

            AddTranslations("vLang", new Dictionary<string, string>
            {
                {"Commun", "Common"},
                {"Humains", "Humans"}
            });

            AddTranslations("vSkills", new Dictionary<string, string>
            {
                {"Acrobaties", "Acrobatics"},
                {"Arcanes", "Arcana"},
                {"Athlétisme", "Athletics"},
                {"Connaissance de la rue", "Street knowledge"},
                {"Diplomatie", "Diplomacy"},
                {"Discrétion", "Discretion"}
            });

            AddTranslations("vVision", new Dictionary<string, string>
            {
                {"normale", "normal"},
                {"nocturne", "nocturnal"}
            });

            AddTranslations("help", new Dictionary<string, string>
            {
                {"help", "get the command guide of the system"},
                {"vLang", "get the list of languages"},
                {"vSkills", "get the list of skills"},
                {"vVision", "get the list of possible visions"},
                {"switch XX", "change the language of the software (Replace XX with EN or FR as desired)"}
            });
        }

        private void AddTranslations(string category, Dictionary<string, string> translationsForCategory)
        {
            translations.Add(category, translationsForCategory);
        }

        public string Translate(string key, string language)
        {
            if (language == null)
            {
                return key;
            }

            if (translations.ContainsKey(key))
            {
                var categoryTranslations = translations[key];

                if (categoryTranslations.ContainsKey(language))
                {
                    return categoryTranslations[language];
                }
            }

            return key;
        }

    }
}
