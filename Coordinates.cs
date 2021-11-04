using System;
using System.Collections.Generic;
using System.Text;

namespace Nesne2Lab_1
{
    public class Coordinates
    {
        public int x, y;
        public Coordinates()
        {
            x = 0;
            y = 0;
        }
        public Coordinates(int _x, int _y)
        {
            if (_x < 1025 && _x > -1025 && _y < 1025 && _y > -1025)
            {
                x = _x;
                y = _y;
            }
            else
            {
                Console.WriteLine("Coordinates are not in range");
            }
        }
        public Coordinates West(Coordinates c,int left)
        {
            c.x = (c.x + left) / 2;
            return c;
        }
        public Coordinates East(Coordinates c, int right)
        {
            c.x = (c.x + right) / 2;
            return c;
        }
        public Coordinates North(Coordinates c, int upward)
        {
            c.y = (c.y + upward) / 2;
            return c;
        }
        public Coordinates South(Coordinates c, int downward)
        {
            c.y = (c.y + downward) / 2;
            return c;
        }
        public string PrintC(Coordinates c)
        {
            string x = c.x.ToString();
            string y = c.y.ToString();
            string rt = "x: " + x + " " + "y: " + y;
            return rt;
        }
    }
}
