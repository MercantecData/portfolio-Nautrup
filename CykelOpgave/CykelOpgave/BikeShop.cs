﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class BikeShop
    {
        private List<Bike> bikeList;

        public BikeShop()
        {
            bikeList = new List<Bike>();
        }

        public void AddBike(Bike bike)
        {
            bikeList.Add(bike);
        }

        public List<string> GetAllBrands()
        {
            List<string> brands = new List<string>();
            
            foreach (Bike bike in bikeList)
            {
                if (!brands.Contains(bike.brand))
                {
                    brands.Add(bike.brand);
                }
            }
            return brands;
        }

        public List<Bike> ReturnBikeWithLargerWheels(double size)
        {
            List<Bike> bikes = new List<Bike>();
            foreach (var bike in bikeList)
            {
                if (bike.wheelSize >= size)
                {
                    bikes.Add(bike);
                }
                else
                {
                     Console.WriteLine("Ingen cykler med denne dæk størrelse tilgængelig");
                }
            }
            return bikes;
        }

        public List<Bike> ReturnBikeWithSmallerWheels(double size)
        {
            List<Bike> bikes = new List<Bike>();
            foreach (var bike in bikeList)
            {
                if (bike.wheelSize <= size)
                {
                    bikes.Add(bike);
                }
            }
            return bikes;
        }

        public List<Bike> SearchBikeBrand(string brand)
        {
            List<Bike> brandList = new List<Bike>();

            for (int i = 0; i < bikeList.Count; i++)
            {
                if (brand == bikeList[i].brand)
                {
                    brandList.Add(bikeList[i]);
                }
            }
            if (brandList.Count > 0)
            {
                Console.WriteLine("Mærke fundet.");
                
            }
            else
            {
                Console.WriteLine("Mærke ikke fundet");
            }
            return brandList;
        }
    }
}
