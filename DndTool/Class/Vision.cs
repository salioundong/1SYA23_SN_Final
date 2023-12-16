using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndTool.Class
{
    public class Vision
    {
        private String name;

        public Vision(String name) 
        { 
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }
    }
}
