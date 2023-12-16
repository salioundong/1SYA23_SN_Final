using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndTool.Class;

namespace DndTool.Factory
{
    public class GFactory
    {
        // Ce factory sert aux fonctions générales du programme

        public List<Language> InitializeLanguages()
        { 
            List<Language> list = new List<Language>();
            List<Race> races = new List<Race>();

            Race demon = new Race("Démons");
            Race gnoll = new Race("gnolls");
            Race dragon = new Race("Dragons");
            Race elf = new Race("Elfes");
            Race dwarf = new Race("Nains");
            Race human = new Race("Humains");

            races.Add(demon);
            races.Add(gnoll);
            Language lang = new Language("Abyssal",races, "Barazhad");
            list.Add(lang);

            races.Clear();
            races.Add(human);
            lang = new Language("Commun", races, "Commune");
            list.Add(lang);

            //...

            return list;
        }

        public List<Skill> InitializeSkills()
        { 
            List<Skill> list = new List<Skill>();

            Skill skill = new Skill("Acrobaties");
            list.Add(skill);
            skill = new Skill("Arcanes");
            list.Add(skill);
            skill = new Skill("Athlétisme");
            list.Add(skill);
            skill = new Skill("Bluff");
            list.Add(skill);
            skill = new Skill("Connaissance de la rue");
            list.Add(skill);
            skill = new Skill("Diplomatie");
            list.Add(skill);
            skill = new Skill("Discrétion");
            list.Add(skill);
            skill = new Skill("Endurance");
            list.Add(skill);

            //...

            return list;
        }

        public List<Vision> InitializeVisions()
        {
            List<Vision> visions = new List<Vision>();

            Vision normal = new Vision("normale");
            Vision night = new Vision("nocturne");

            visions.Add(normal);
            visions.Add(night);

            return visions;
        }

        public void GetCommands()
        {
            // Imprime toutes les commandes et explications nécessaire pour utiliser l'application
            Console.WriteLine("help : obtenir le guide des commandes du systèmes");
            Console.WriteLine("vLang : Obtenir la liste des langages ");
            Console.WriteLine("vSkills : Obtenir la liste des skills");
            Console.WriteLine("vVision : Obtenir la liste des visions possibles");
            Console.WriteLine("switch XX : Permet de changer la langue du logiciel (Remplacer XX pour EN ou FR selon la langue désirée");
        }

        public List<Language> GetLanguages()
        {
            List<Language> languages = this.InitializeLanguages();
            foreach(Language lang in languages) Console.WriteLine(lang.GetName() + " : " + lang.GetDefaultRaces() + " : " + lang.GetWriting());
            Console.WriteLine("");
            return languages;
        }

        public List<Skill> GetSkills()
        {
            List<Skill> skills = this.InitializeSkills();
            foreach (Skill skill in skills) Console.WriteLine(skill.GetName());
            Console.WriteLine("");
            return skills;
        }

        public List<Vision> GetVisions() 
        { 
            List<Vision> visions = this.InitializeVisions();
            foreach (Vision vision in visions) Console.WriteLine(vision.GetName());
            Console.WriteLine("");
            return visions;
        }

        public void ExecuteCommand(String command, String[] inputs)
        {
            // Étape 2 : A complété
        }

        public String RequestCommand(String input)
        {
            // Étape 2 : A complété
            return "";
        }
    }
}
