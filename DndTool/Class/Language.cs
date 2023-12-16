using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class Language
    {
        public String name;
        public List<Race> talkedBy;
        public String writing;

        public Language(String name, List<Race> races, String writing) 
        {
            this.name = name;
            this.talkedBy = races;
            this.writing = writing;
        }

        public String GetName()
        {
            return this.name;
        }

        public String GetDefaultRaces()
        {
            //Récupère seulement le nom de la race
            String races = "";
            foreach (Race race in this.talkedBy)
            {
                if (races != "") races += ", ";
                races += race.GetName();
                
            }
            return races;
        }

        public String GetWriting()
        {
            return this.writing;
        }
    }
}
