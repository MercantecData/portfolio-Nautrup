using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadplanProjekt
{
    class Dessert
    {
        public string name;
        public List<Ingrediens> ingrediens;

        public Dessert(string name, List<Ingrediens> ingrediens)
        {
            this.name = name;
            this.ingrediens = ingrediens;
        }
    }
}
