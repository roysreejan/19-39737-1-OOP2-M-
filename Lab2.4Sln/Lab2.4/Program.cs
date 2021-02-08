using System;

namespace Lab2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumofEven = 0, SumofOdd = 0;
            for(int i= 1; i<=100; i++)
            {
                if(i%2==0)
                {
                    SumofEven = SumofEven + i;
                }
                else
                {
                    SumofOdd = SumofOdd + i;
                }
            }
            Console.WriteLine("Sum of Even Number from 1 to 100: " + SumofEven);
            Console.WriteLine("Sum of Odd Number from 1 to 100: " + SumofOdd);
        }
    }
}
