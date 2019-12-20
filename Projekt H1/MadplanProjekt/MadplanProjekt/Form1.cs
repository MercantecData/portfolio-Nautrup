using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadplanProjekt
{
    public partial class Form1 : Form
    {
        List<Dish> allDishes = new List<Dish>();
        List<Dessert> allDesserts = new List<Dessert>();
        List<Dish> dishesForTheWeek = new List<Dish>();
        Random chooseDish = new Random();
        string path = @"Indkøbsliste.txt";

        public Form1()
        {
            InitializeComponent();
        }
        
        //Methods and functions
        private List<Dish> GetDishData()
        {
            List<Dish> localList = new List<Dish>();

            Dish BollerIKarry = new Dish("Boller i karry", new List<Ingrediens>());
            BollerIKarry.Ingrediens.Add(new Ingrediens("ris", 5));
            BollerIKarry.Ingrediens.Add(new Ingrediens("karry", 10));
            localList.Add(BollerIKarry);

            Dish pandekager = new Dish("Pandekager", new List<Ingrediens>());
            pandekager.Ingrediens.Add(new Ingrediens("Mel", 10));
            pandekager.Ingrediens.Add(new Ingrediens("Æg", 20));
            pandekager.Ingrediens.Add(new Ingrediens("Mælk", 10));
            pandekager.Ingrediens.Add(new Ingrediens("Sukker", 10));
            localList.Add(pandekager);

            Dish lasagne = new Dish("Lasagne", new List<Ingrediens>());
            lasagne.Ingrediens.Add(new Ingrediens("Knorr Lasagne Mix", 25));
            lasagne.Ingrediens.Add(new Ingrediens("Oksekød", 25));
            lasagne.Ingrediens.Add(new Ingrediens("Mælk", 8));
            localList.Add(lasagne);

            //Ja jeg blev doven og gad ikke sætte ingredienser ind på alle... Deal with it
            Dish pasta = new Dish("Pasta & Kødsovs", new List<Ingrediens>());
            pasta.Ingrediens.Add(new Ingrediens("Pasta af egen valg", 7));
            pasta.Ingrediens.Add(new Ingrediens("Oksekød", 25));
            pasta.Ingrediens.Add(new Ingrediens("Hvidløg", 10));
            pasta.Ingrediens.Add(new Ingrediens("Hakket tomater", 4));
            localList.Add(pasta);

            Dish taco = new Dish("Taco", new List<Ingrediens>());
            taco.Ingrediens.Add(new Ingrediens("Oksekød", 25));
            taco.Ingrediens.Add(new Ingrediens("Hvidløg", 10));
            taco.Ingrediens.Add(new Ingrediens("Taco Skalder", 16));
            taco.Ingrediens.Add(new Ingrediens("Hakket tomater", 4));
            localList.Add(taco);

            Dish kyllingRis = new Dish("Kylling m/ Ris", new List<Ingrediens>());
            kyllingRis.Ingrediens.Add(new Ingrediens("Kyllingebryst", 25));
            kyllingRis.Ingrediens.Add(new Ingrediens("Hvidløg", 10));
            kyllingRis.Ingrediens.Add(new Ingrediens("Ris", 6));
            localList.Add(kyllingRis);

            Dish kartoffelMos = new Dish("Kartoffelmos", new List<Ingrediens>());
            kartoffelMos.Ingrediens.Add(new Ingrediens("Kartoffler", 10));
            kartoffelMos.Ingrediens.Add(new Ingrediens("Mælk", 8));
            kartoffelMos.Ingrediens.Add(new Ingrediens("Smør", 10));
            kartoffelMos.Ingrediens.Add(new Ingrediens("Kød af eget valg", 25));
            localList.Add(kartoffelMos);

            Dish Suppe = new Dish("Suppe", new List<Ingrediens>());
            Suppe.Ingrediens.Add(new Ingrediens("Boullionterning af eget valg", 14));
            Suppe.Ingrediens.Add(new Ingrediens("Suppe grøntsagsmix", 14));
            localList.Add(Suppe);

            Dish foraarsRuller = new Dish("Forårsruller", new List<Ingrediens>());
            foraarsRuller.Ingrediens.Add(new Ingrediens("Forårsruller", 26));
            localList.Add(foraarsRuller);

            Dish steakDish = new Dish("Bøffer", new List<Ingrediens>());
            steakDish.Ingrediens.Add(new Ingrediens("Oksekød 500g", 25));
            steakDish.Ingrediens.Add(new Ingrediens("Løg", 10));
            localList.Add(steakDish);

            Dish dunser = new Dish("Frikadeller", new List<Ingrediens>());
            dunser.Ingrediens.Add(new Ingrediens("Grisefars 500g", 25));
            dunser.Ingrediens.Add(new Ingrediens("Løg", 10));
            dunser.Ingrediens.Add(new Ingrediens("Mel", 10));
            localList.Add(dunser);

            Dish koteletterIFad = new Dish("Koteletter i fad", new List<Ingrediens>());
            koteletterIFad.Ingrediens.Add(new Ingrediens("Koteletter", 25));
            koteletterIFad.Ingrediens.Add(new Ingrediens("Hakket tomat", 4));
            koteletterIFad.Ingrediens.Add(new Ingrediens("Hvidløg", 10));
            localList.Add(koteletterIFad);

            Dish bofStroganof = new Dish("Bøf Stroganoff", new List<Ingrediens>());
            bofStroganof.Ingrediens.Add(new Ingrediens("Oksefillet", 25));
            bofStroganof.Ingrediens.Add(new Ingrediens("Svampe", 7));
            bofStroganof.Ingrediens.Add(new Ingrediens("Løg", 10));
            localList.Add(bofStroganof);

            Dish logtaerte = new Dish("Løgtærte", new List<Ingrediens>());
            logtaerte.Ingrediens.Add(new Ingrediens("Tærtedej", 14));
            logtaerte.Ingrediens.Add(new Ingrediens("Løg", 10));
            logtaerte.Ingrediens.Add(new Ingrediens("Bacon", 15));
            logtaerte.Ingrediens.Add(new Ingrediens("Peberfrugt", 10));
            localList.Add(logtaerte);

            Dish wokRet = new Dish("Wokret", new List<Ingrediens>());
            wokRet.Ingrediens.Add(new Ingrediens("Put hvad du vil i. Wokretter smager altid godt", 50));
            localList.Add(wokRet);
            
            Dish fishDish = new Dish("Fiskfillet", new List<Ingrediens>());
            fishDish.Ingrediens.Add(new Ingrediens("Fiskefillet", 32));
            fishDish.Ingrediens.Add(new Ingrediens("Ris", 6));
            localList.Add(fishDish);

            Dish homemadePizza = new Dish("Hjemmelavet pizza", new List<Ingrediens>());
            homemadePizza.Ingrediens.Add(new Ingrediens("Pizza dej", 14));
            homemadePizza.Ingrediens.Add(new Ingrediens("Ost", 16));
            homemadePizza.Ingrediens.Add(new Ingrediens("Valgfrie toppings", 40));
            localList.Add(homemadePizza);

            Dish kyllingFrikadeller = new Dish("Kyllinge Frikadeller", new List<Ingrediens>());
            kyllingFrikadeller.Ingrediens.Add(new Ingrediens("Kyllingfars 500g", 25));
            kyllingFrikadeller.Ingrediens.Add(new Ingrediens("Løg", 10));
            kyllingFrikadeller.Ingrediens.Add(new Ingrediens("Hvidløg", 10));
            localList.Add(kyllingFrikadeller);

            Dish stegtflaesk = new Dish("Stegt Flæsk", new List<Ingrediens>());
            stegtflaesk.Ingrediens.Add(new Ingrediens("Flæsk", 25));
            stegtflaesk.Ingrediens.Add(new Ingrediens("Kartoffler", 10));
            stegtflaesk.Ingrediens.Add(new Ingrediens("Persillesovs", 15));
            localList.Add(stegtflaesk);
            
            Dish sandwich = new Dish("Sandwich", new List<Ingrediens>());
            sandwich.Ingrediens.Add(new Ingrediens("Bestem selv", 25));
            localList.Add(sandwich);
            
            Dish potatoSoup = new Dish("Kartoffel suppe", new List<Ingrediens>());
            potatoSoup.Ingrediens.Add(new Ingrediens("Kartoffler", 25));
            potatoSoup.Ingrediens.Add(new Ingrediens("Porre", 10));
            potatoSoup.Ingrediens.Add(new Ingrediens("Boullion Grøntsags", 15));
            localList.Add(potatoSoup);

            Dish hamburgerryg = new Dish("Glaseret Hamburgerryg", new List<Ingrediens>());
            hamburgerryg.Ingrediens.Add(new Ingrediens("Hamburgerryg", 35));
            hamburgerryg.Ingrediens.Add(new Ingrediens("Din favorit marinade", 25));
            hamburgerryg.Ingrediens.Add(new Ingrediens("Kartoffler", 15));
            localList.Add(hamburgerryg);

            Dish dish17 = new Dish("Æggekage m/ bacon", new List<Ingrediens>());
            dish17.Ingrediens.Add(new Ingrediens("Æg", 35));
            dish17.Ingrediens.Add(new Ingrediens("Bacon", 25));
            dish17.Ingrediens.Add(new Ingrediens("Kartoffler & grøntsager", 15));
            localList.Add(dish17);

            Dish dish18 = new Dish("Ret 18", new List<Ingrediens>());
            dish18.Ingrediens.Add(new Ingrediens("Ret 18", 35));
            dish18.Ingrediens.Add(new Ingrediens("Ret 18", 25));
            dish18.Ingrediens.Add(new Ingrediens("Ret 18", 15));
            localList.Add(dish18);

            Dish dish19 = new Dish("Ret 19", new List<Ingrediens>());
            dish19.Ingrediens.Add(new Ingrediens("Ret 19", 35));
            dish19.Ingrediens.Add(new Ingrediens("Ret 19", 25));
            dish19.Ingrediens.Add(new Ingrediens("Ret 19", 15));
            localList.Add(dish19);

            Dish dish20 = new Dish("Ret 20", new List<Ingrediens>());
            dish20.Ingrediens.Add(new Ingrediens("Ret 20", 35));
            dish20.Ingrediens.Add(new Ingrediens("Ret 20", 25));
            dish20.Ingrediens.Add(new Ingrediens("Ret 20", 15));
            localList.Add(dish20);

            return localList;
        }

        private List<Dessert> GetDessertData()
        {
            List<Dessert> localList = new List<Dessert>();

            Dessert dessert1 = new Dessert("Pandekager m/ is", new List<Ingrediens>());
            dessert1.ingrediens.Add(new Ingrediens("Is", 20));                              
            dessert1.ingrediens.Add(new Ingrediens("Easy Pandekage mix", 23));
            dessert1.ingrediens.Add(new Ingrediens("Mælk", 8));
            localList.Add(dessert1);

            Dessert dessert2 = new Dessert("Jordbær tærte", new List<Ingrediens>());
            dessert2.ingrediens.Add(new Ingrediens("Jordbær", 20));
            dessert2.ingrediens.Add(new Ingrediens("Vaniljecreme", 23));
            dessert2.ingrediens.Add(new Ingrediens("Easy Bake Tærtedej", 18));
            localList.Add(dessert2);

            Dessert dessert3 = new Dessert("Chokoladekage", new List<Ingrediens>());
            dessert3.ingrediens.Add(new Ingrediens("Easy Bake Chokoladekage", 20));
            dessert3.ingrediens.Add(new Ingrediens("Æg", 23));
            dessert3.ingrediens.Add(new Ingrediens("Mælk", 8));
            localList.Add(dessert3);

            Dessert dessert4 = new Dessert("Bland selv slik", new List<Ingrediens>());
            dessert4.ingrediens.Add(new Ingrediens("", 50));
            localList.Add(dessert4);

            Dessert dessert5 = new Dessert("Chokolademousse", new List<Ingrediens>());
            localList.Add(dessert5);

            Dessert dessert6 = new Dessert("Brun sovs(Jyde dessert)", new List<Ingrediens>());
            dessert6.ingrediens.Add(new Ingrediens("Spørg mor om hun ikke vil lave den", 0));
            localList.Add(dessert6);

            Dessert dessert7 = new Dessert("Banansplit", new List<Ingrediens>());
            dessert7.ingrediens.Add(new Ingrediens("Banan", 2));
            dessert7.ingrediens.Add(new Ingrediens("Is", 35));
            localList.Add(dessert7);

            return localList;
        }
        
        private void CreateWeeklyPlan()
        {
            int randomDish = chooseDish.Next(0, allDishes.Count);
            //int randomDessert = chooseDish.Next(0, allDesserts.Count);

            //Monday
            randomDish = chooseDish.Next(0, allDishes.Count);   // gets a dish from allDishes
            lMonday.Text = allDishes[randomDish].name;          // puts the name into a label
            dishesForTheWeek.Add(allDishes[randomDish]);        // add the chosen dish to a list of this weeks dishes
            allDishes.RemoveAt(randomDish);                     // removes it from the allDishes list, so it wont be choosen again.

            //Tuesday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lTuesday.Text = allDishes[randomDish].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);

            //Wensday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lWensday.Text = allDishes[randomDish].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);

            //Thursday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lThursday.Text = allDishes[randomDish].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);

            //Friday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lFriday.Text = allDishes[randomDish].name;
            //lDessert.Text = allDesserts[randomDessert].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);

            //Saturday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lSaturday.Text = allDishes[randomDish].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);

            //Sunday
            randomDish = chooseDish.Next(0, allDishes.Count);
            lSunday.Text = allDishes[randomDish].name;
            dishesForTheWeek.Add(allDishes[randomDish]);
            allDishes.RemoveAt(randomDish);
        }

        private void CreateDessertPlan()
        {
            int randomDish = chooseDish.Next(0, allDesserts.Count); // choose a dessert from allDishes
            lMonday.Text = allDesserts[randomDish].name;            // puts that name of the dessert in a label
            allDesserts.RemoveAt(randomDish);                       // removes it from the list, so it doesnt get choosen again in the same week.

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lTuesday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lWensday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lThursday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lDessert.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lSaturday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lSunday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);
        }

        private void CreateShoppingList()
        {
            
            double totalPrice = 0;
            
            StreamWriter shoppingList = new StreamWriter(path);
            foreach (Dish dish in dishesForTheWeek)
            {
                shoppingList.WriteLine("Ret: " + dish.name + "\nIngredienser:");
                for (int i = 0; i < dish.Ingrediens.Count; i++)
                {
                    shoppingList.WriteLine(dish.Ingrediens[i].name + " - " + dish.Ingrediens[i].price + " kr.");
                    totalPrice += dish.Ingrediens[i].price;
                }
                shoppingList.WriteLine("-----------------------");
            }
            shoppingList.WriteLine("Pris for hele ugen : " + totalPrice + " kr.");
            shoppingList.WriteLine("-----------------------");
            shoppingList.WriteLine("Noter:");
            shoppingList.WriteLine(rtbMenuBox.Text);
            shoppingList.Close();
            dishesForTheWeek.Clear();
            Process.Start(path);
        }

        //Buttons and Events
        private void bCreatePlan_Click(object sender, EventArgs e)
        {
            if (cbDessert.Checked)
            {
                allDesserts = GetDessertData();
                CreateDessertPlan();
               
            }
            else
            {
                allDishes = GetDishData(); //get all the dishes everytime button is pressed so we dont get an error.
                CreateWeeklyPlan();
            }
        }

        private void cbDessert_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDessert.Checked)
            {
                cbCheatDay.Enabled = false;
                cbCheatDay.Checked = false;
                allDesserts = GetDessertData();
                CreateDessertPlan();
            }
            else
            {
                cbCheatDay.Enabled = true;
                allDishes = GetDishData();
                CreateWeeklyPlan();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allDishes = GetDishData();
            allDesserts = GetDessertData();
            CreateWeeklyPlan();
            dishesForTheWeek.Clear();
            lTotalAmountOfDishes.Text = "Antal Retter: " + (allDishes.Count + allDesserts.Count);
        }

        private void cbCheatDay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheatDay.Checked)
            {
                lDessert.Visible = true;
            }
            else
            {
                lDessert.Visible = false;
            }
        }

        private void bCreateShoppingList_Click(object sender, EventArgs e)
        {
            CreateShoppingList();
        }

        private void bOpenShoppingList_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Ingen indkøbsliste fundet.");
            }
            else
            {
                Process.Start(path);
            }
           
        }
    }
}
