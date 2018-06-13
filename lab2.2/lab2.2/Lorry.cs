using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Lorry : Vehicle
    {
        private int maxWeight;
        private int height;
        public int Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }
        public int MaxWeight
        {
            set
            {
                if (value > 0)
                {
                    maxWeight = value;
                }
            }
            get
            {
                return maxWeight;
            }
        }
        
        public Lorry(int price, int year, int serialNumber) : base(price,year,serialNumber)
        {
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
