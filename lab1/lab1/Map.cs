using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Map
    {
        private static int number;
        private int minLength;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0)
                {
                    number = value;
                }
            }
        }
        private House[] houses;
        public void GetHouses()
        {
            for (int i=0 ; i<number ; i++)
            {
                Console.WriteLine("Водим координати дома номер" + i);
                Console.WriteLine("Введіть x " + i + "-го будинку");
                houses[i].X = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введіть y " + i + "-го будинку");
                houses[i].Y = Int32.Parse(Console.ReadLine());
            }
        }
        private double[,] length;
        private void findLength()
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == j)
                    {
                        length[i, j] = 0;
                    }
                    else
                    {
                        int Xdifference = houses[i].X - houses[j].X;
                        int Ydifference = houses[i].Y - houses[j].Y;
                        length[i, j] = Math.Sqrt(Math.Pow(Xdifference, 2) + Math.Pow(Ydifference, 2));
                    }
                }
            }
        }
        public double findMin(int j)
        {
            double result=-2;
            for (int i = 0; i < number; i++)
            {
                if (!(houses[i].getConnect()) && length[j, i] != 0)
                {
                    result = length[j, i];
                }
                else
                {
                    result = -1;
                }
            }
            if (result != -1)
            {
                for (int i = 0; i < number; i++)
                {
                    if (length[j, i] != 0 && length[j, i] < result && !(houses[i].getConnect()))
                    {
                        result = length[j, i];
                    }
                }
            }
           return result;
        }
        int ri = -1;
        int rj = -1;
        public double findnMin()
        {
            double min=-1;
            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    if (i == 0 && j==1)
                    {
                        min = length[i,j];
                        ri = i;
                        rj = j;
                    }
                    else
                    {
                        if(length[i,j]!=0 && length[i, j] <= min && !(houses[i].getConnect() && houses[j].getConnect()))
                        {
                            min= length[i, j];
                            ri = i;
                            rj = j;
                        }
                    }
                }
            }
            /*for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    min = findMin(i);
                    result = i;
                }
                else
                {
                    for (int k = 0; k < number; k++)
                    {
                        if (houses[k].getConnect())
                        {
                            if (k == 0)
                            {
                                min = findMin(k);
                                result = i;
                            }
                            else
                            {
                                if (findMin(k) < min)
                                {
                                    min = findMin(k);
                                    result = k;
                                }
                            }
                        }
                    }
                }
            }*/
            return min;
        }
        public double culculate()
        {
            findLength();
            double result = 0;
            for(int i = 0; i < number-1; i++)
            {
                double r = findnMin();
                result += r;
                //length[i, k] = 0;
                houses[ri].setConnect();
                houses[rj].setConnect();
                Console.WriteLine("Будинки номер " + ri +" "+ rj + " довжина " + r);
            }
            return result;
        }
        public Map(int n)
        {
            number = n;
            houses = new House[n];
            for(int i = 0; i < n; i++)
            {
                houses[i] = new House();
            }
            length = new double[n, n];
            }
    }
}
