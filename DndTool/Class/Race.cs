using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class Race
    {
        private String name;

        public Race(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }
    }
}
