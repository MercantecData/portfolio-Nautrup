using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class Bike
    {
        public string brand;
        public double wheelSize;
        public string color;
        public bool withMotor;

        private int numOfbikes = 0;

        public Bike(string brand, double wheelSize, string color, bool withMotor)
        {
            this.brand = brand;
            this.wheelSize = wheelSize;
            this.color = color;
            this.withMotor = withMotor;
            numOfbikes += 1;
        }

        public int GetTotalAmountOfBikes()
        {
            return numOfbikes;
        }
    }
}
