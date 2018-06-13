using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    abstract class Vehicle
    {
        protected int price;
        protected int maxSpeed;
        protected int year;
        protected int weight;
        protected String color;
        protected String brand;
        protected int serialNumber;
        public Vehicle(int price, int year, int serialNumber)
        {
            this.price = price;
            this.year = year;
            this.serialNumber = serialNumber;
        }
        public int MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
            }
            get
            {
                return maxSpeed;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
        public int SerialNumber
        {
            get
            {
                return serialNumber;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
        }
        public String Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        public String Brand
        {
            set
            {
                brand = value;
            }
            get
            {
                return brand;
            }
        }
        public int Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
            get
            {
                return weight;
            }
        }
        public virtual void Show()
        {
            Console.WriteLine(this.SerialNumber + " " + this.Year + " " + this.Price);
        }
    }
}
