using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
        //properties
        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        //constructor
        public Triangle()
        {
            Console.WriteLine("\nTriangle craeted with default");
        }

        public Triangle(int x, int y, int z)
        {
            Console.WriteLine("\nTriangle created with 3 parameter");
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void TestTriangle()
        {
            if (this.x == this.y && this.y == this.z)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else if (this.x == this.y || this.y == this.z || this.z == this.x)
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is isosceles");
            }

            Console.WriteLine("Test Triable: {0} {1} {2}",x,y,z);
        }

        public void ShowInfo()
        {
            Console.WriteLine("X: " + this.x);
            Console.WriteLine("Y: " + this.y);
            Console.WriteLine("Z: " + this.z);
        }

    }
}