using System;
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
                Console.WriteLine(bike.brand);
            }
            return brands;
        }
    }
}
