using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            foraarsRuller.Ingrediens.Add(new Ingrediens("Forårsruller", 8));
            localList.Add(foraarsRuller);

            Dish steakDish = new Dish("Bøffer", new List<Ingrediens>());
            localList.Add(steakDish);

            Dish dunser = new Dish("Frikadeller", new List<Ingrediens>());
            localList.Add(dunser);

            Dish koteletterIFad = new Dish("Koteletter i fad", new List<Ingrediens>());
            localList.Add(koteletterIFad);

            Dish bofStroganof = new Dish("Bøf Stroganoff", new List<Ingrediens>());
            localList.Add(bofStroganof);

            Dish logtaerte = new Dish("Løgtærte", new List<Ingrediens>());
            localList.Add(logtaerte);

            Dish wokRet = new Dish("Wokret", new List<Ingrediens>());
            localList.Add(wokRet);
            
            Dish fishDish = new Dish("Fisk m. Ris", new List<Ingrediens>());
            localList.Add(fishDish);

            Dish homemadePizza = new Dish("Hjemmelavet pizza", new List<Ingrediens>());
            localList.Add(homemadePizza);

            Dish frikadeller = new Dish("Frikadeller", new List<Ingrediens>());
            localList.Add(frikadeller);

            Dish kyllingFrikadeller = new Dish("Kyllinge Frikadeller", new List<Ingrediens>());
            localList.Add(kyllingFrikadeller);

            Dish stegtflaesk = new Dish("Stegt Flæsk", new List<Ingrediens>());
            localList.Add(stegtflaesk);
            
            Dish sandwich = new Dish("Sandwich", new List<Ingrediens>());
            localList.Add(sandwich);
            
            Dish potatoSoup = new Dish("Kartoffel suppe", new List<Ingrediens>());
            localList.Add(potatoSoup);

            Dish hamburgerryg = new Dish("Glaseret Hamburgerryg", new List<Ingrediens>());
            localList.Add(hamburgerryg);

            Dish dish17 = new Dish("Æggekage m/ bacon", new List<Ingrediens>());
            localList.Add(dish17);

            Dish dish18 = new Dish("Ret 18", new List<Ingrediens>());
            localList.Add(dish18);

            Dish dish19 = new Dish("Ret 19", new List<Ingrediens>());
            localList.Add(dish19);

            Dish dish20 = new Dish("Ret 20", new List<Ingrediens>());
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

            Dessert dessert4 = new Dessert("Brombærkompot", new List<Ingrediens>());
            dessert4.ingrediens.Add(new Ingrediens("Brombær", 20));
            dessert4.ingrediens.Add(new Ingrediens("I dont know? sukker?", 23));
            dessert4.ingrediens.Add(new Ingrediens("Mælk måske?", 8));
            localList.Add(dessert4);

            Dessert dessert5 = new Dessert("Chokolademousse", new List<Ingrediens>());
            localList.Add(dessert5);

            Dessert dessert6 = new Dessert("Frugtsalat", new List<Ingrediens>());
            localList.Add(dessert6);

            Dessert dessert7 = new Dessert("Banansplit", new List<Ingrediens>());
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
            lFriday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lSaturday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);

            randomDish = chooseDish.Next(0, allDesserts.Count);
            lSunday.Text = allDesserts[randomDish].name;
            allDesserts.RemoveAt(randomDish);
        }

        private void PrintWeeklyPlanToTextBox()
        {
            int counter = 1;
            rtbMenuBox.Clear();
            foreach (var dish in dishesForTheWeek)
            {
                rtbMenuBox.Text += "Dag: " + counter++ + " Ret: " + dish.name + "\n";    
            }
        } // Ikke i brug endnu

        private void CreateShoppingList()
        {
            string path = @"Indkøbsliste.txt";
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
            shoppingList.Close();
            dishesForTheWeek.Clear();
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
                //PrintWeeklyPlanToTextBox(); // prints the weekly plan out in the textbox
            }
        }

        private void cbDessert_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDessert.Checked)
            {
                cbCheatDay.Enabled = false;
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
            rtbMenuBox.Text = "Dette er kun en lille hjælp til hvad du f.eks. kan lave af mad.\nDu er velkommen til at trykke på 'Lav madplan' knappen for at se hvordan en uge ellers kan se ud.";
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

    }
}
