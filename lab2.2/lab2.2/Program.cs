using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage1 = new Garage();
            Car car1 = new Car(10000, 2015, 123456);
            Car car2 = new Car(150000, 2018, 34);
            Bicycle b1 = new Bicycle(1000, 2016, 456);
            Bicycle b2 = new Bicycle(100, 2014, 56456);
            Lorry lorry1 = new Lorry(14000, 2016, 1456);
            Lorry lorry2 = new Lorry(14500, 2016, 1400);
            car1.Color = "Red";
            car1.Acceleration = 2.4;
            lorry1.MaxWeight = 40;
            garage1.addVehicle(car1);
            garage1.addVehicle(b1);
            garage1.addVehicle(lorry1);
            garage1.addVehicle(b2);
            garage1.addVehicle(lorry2);
            garage1.addVehicle(car2);
            garage1.ShowCollection();
            Console.WriteLine(car1.Color);
            Console.WriteLine(car1.Acceleration);
            Console.WriteLine(lorry1.MaxWeight);
            garage1.ShowVehicle(2);
            Console.ReadKey();
        }
    }
}
