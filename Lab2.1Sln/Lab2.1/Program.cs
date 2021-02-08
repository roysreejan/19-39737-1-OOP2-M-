using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i;
            Console.WriteLine("Even numbers: ");
            {
                for (i = 1; i <= n; i++)
                {
                    if (i% 2 == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
