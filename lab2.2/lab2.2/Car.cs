using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Car : Vehicle
    {
        public Car(int price, int year, int serialNumber) : base(price, year, serialNumber)
        {
        }
        private double acceleration; //time to 100km/h
        private int numberOfSeats;
        public double Acceleration
        {
            set
            {
                if (value > 0)
                {
                    acceleration = value;
                }
            }
            get
            {
                return acceleration;
            }
        }
        public int NumberOfSeats
        {
            set
            {
                if (value > 0)
                {
                    numberOfSeats = value;
                }
            }
            get
            {
                return numberOfSeats;
            }
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
