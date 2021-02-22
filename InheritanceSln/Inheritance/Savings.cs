using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Savings : Account
    {
        private int minBalance;
        public int MinBalance
        {
            set { minBalance = value; }
            get { return minBalance; }
        }
        public Savings()
        {
            Console.WriteLine("Savings Created with default");
        }
        public Savings(int minBalance)
        {
            this.minBalance = minBalance;
            Console.WriteLine("Savings Created with 1 parameter");
        }
    }
}
