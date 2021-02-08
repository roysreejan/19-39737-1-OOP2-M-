using System;

namespace Lab2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double phy= 92, chem= 85.7, bio= 85.5, math= 95, computer= 95, sum= 0.0;

            sum = phy+chem+bio+math+computer;
            sum = (100 * sum) / 500;

            if (sum >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (sum >= 85 && sum < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (sum >= 80 && sum < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (sum >= 75 && sum < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (sum >= 50 && sum < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine("");
        }
    }
}
