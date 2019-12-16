using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadplanProjekt
{
    public partial class Form1 : Form
    {
        
        List<Dish> allDishes = new List<Dish>();
        public Form1()
        {
            InitializeComponent();
            OnAppstart();
        }

        private void OnAppstart()
        {
            rtbMenuBox.Text = "Her er et forslag til en madplan for en uge. Er du ikke tilfreds kan du trykke på 'Lav madplan' kanppen, så får du lavet en ny madplan.";
            allDishes = GetDishData();
            lTotalAmountOfDishes.Text = "Antal Retter: " + allDishes.Count;
        }

        private List<Dish> GetDishData()
        {
            List<Dish> localList = new List<Dish>();

            Dish dish1 = new Dish("Lasagne", new List<Ingrediens>());
            dish1.Ingrediens.Add(new Ingrediens("Knorr lasagne mix", 25));
            dish1.Ingrediens.Add(new Ingrediens("Oksekød", 25));
            dish1.Ingrediens.Add(new Ingrediens("Mælk", 8));
            localList.Add(dish1);

            Dish dish2 = new Dish("Tarteletter", new List<Ingrediens>());
            dish2.Ingrediens.Add(new Ingrediens("Kylling fyld", 35));
            dish2.Ingrediens.Add(new Ingrediens("Tartelet skalder", 15));
            localList.Add(dish2);

            Dish dish3 = new Dish("Toast", new List<Ingrediens>());
            dish3.Ingrediens.Add(new Ingrediens("Toastbrød", 10));
            dish3.Ingrediens.Add(new Ingrediens("Toast ost", 15));
            dish3.Ingrediens.Add(new Ingrediens("Hamburgerryg", 9));
            localList.Add(dish3);

            return localList;
        }
    }
}
