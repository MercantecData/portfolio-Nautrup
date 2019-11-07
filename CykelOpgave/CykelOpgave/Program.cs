﻿using System;
using System.Collections.Generic;

namespace CykelOpgave
{
    class Program
    {
        static BikeShop JonasCykler = new BikeShop();
        static BikeShop SeldeCykler = new BikeShop();

        static void Main(string[] args)
        {
            JonasCykler.AddBike(new Bike("Mustang", 16, "Blue", false));
            JonasCykler.AddBike(new Bike("Mustang", 20, "Red", true));
            JonasCykler.AddBike(new Bike("Centurion", 12, "Green", true));
            JonasCykler.AddBike(new Bike("Centurion", 24, "Yellow", true));
            JonasCykler.AddBike(new Bike("Giant", 10, "Purple", false));
            JonasCykler.AddBike(new Bike("Giant", 11, "Blue", false));

            SeldeCykler.AddBike(new Bike("Uden sæde", 11, "Yellow", true));
            SeldeCykler.AddBike(new Bike("TooFast", 11, "White", false));
            SeldeCykler.AddBike(new Bike("Ikke en volvo", 11, "Metallic Blue", false));
            SeldeCykler.AddBike(new Bike("Dyt dyt", 11, "Graphite", false));

            
        }

        static void PrintBikeList()
        {
            Console.WriteLine("All brands available:");
            List<string> brands = JonasCykler.GetAllBrands();

            foreach (var str in brands)
            {
                Console.WriteLine(str);
            }
        }
    }
}