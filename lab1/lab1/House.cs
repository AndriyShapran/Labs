using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class House
    {
        private int x, y;
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        private bool connect=false;
        public void setConnect()
        {
            connect = true;
        }
        public bool getConnect()
        {
            return connect;
        }
    }
}
