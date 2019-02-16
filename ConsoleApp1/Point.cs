using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private int y;
        private int x;

        internal Point(int y, int x)
        {
            this.y = y;
            this.x = x;
        }

       

        internal int Getx()
        {
            return x;

        }

        internal int Gety()
        {
            return y;

        }

        internal void Setx()
        {
            if (x <= 0 || x >= MyCanvas.MAXW)
            {
                Console.WriteLine("X - Invalid point value");
            }
            else
            {
                this.x = x;
            }
        }

        internal void Sety()
        {
            if (y <= 0 || y >= MyCanvas.MAXH)
            {
                Console.WriteLine("Y - Invalid point value");
            }
            else
            {
                this.y = y;
            }
        }

        public override string ToString()
        {
            return $"x : (x) , y : (y)";
        }
    }
}
