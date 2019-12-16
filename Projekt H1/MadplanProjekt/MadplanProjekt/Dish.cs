using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadplanProjekt
{
    class Dish
    {
        string name;
        public List<Ingrediens> Ingrediens;

        public Dish(string name, List<Ingrediens> ingrediens)
        {
            this.name = name;
            Ingrediens = ingrediens;
        }
    }
}
