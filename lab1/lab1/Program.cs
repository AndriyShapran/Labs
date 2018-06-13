using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість будинків");
            int n= Int32.Parse(Console.ReadLine());
            Map a = new Map(n);
            a.GetHouses();
            double l;
            l=a.culculate();
            Console.WriteLine("Загальна довжина " + l);
            Console.ReadKey();
        }
    }
}
