using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Bicycle : Vehicle
    {
        public Bicycle(int price, int year, int serialNumber) : base(price, year, serialNumber)
        {
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
