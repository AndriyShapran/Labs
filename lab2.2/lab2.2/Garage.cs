using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Garage
    {
        private int number;
        private Vehicle[] collection;
        public Garage()
        {
            number = 0;
            Vehicle[] collection = new Vehicle[number];
        }
        public void addVehicle(Vehicle a)
        {
            /*Vehicle[] h = new Vehicle[number+1];
            for(int i = 0; i < number; i++)
            {
                h[i] = collection[i];
            }
            h[number + 1] = a;
            collection = h;*/
            Array.Resize(ref collection, number+1);
            collection[number] = a;
            number++;
        }
        public void ShowCollection()
        {
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(i + " " + collection[i].SerialNumber + " " + collection[i].Year + " " + collection[i].Price);
            }
        }
        public void ShowVehicle(int i)
        {
            collection[i].Show();
        }
    }
}

