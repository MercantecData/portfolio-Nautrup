using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class ShopOwner
    {
        private List<Bike> bikeList;
        private string name;

        public ShopOwner()
        {
            bikeList = new List<Bike>();
        }

        public List<string> GetAllRedBikes() // Not working yet...
        {
            List<string> redBikes = new List<string>();

            foreach (Bike bike in bikeList)
            {
                if (redBikes.Contains(bike.color))
                {
                    redBikes.Add(bike.color);
                }
            }
            return redBikes;
        }

    }
}
