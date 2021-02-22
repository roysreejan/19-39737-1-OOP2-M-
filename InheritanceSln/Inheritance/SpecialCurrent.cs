using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SpecialCurrent : Account
    {
        private int openingBalance;

        public int OpeningBalance
        {
            set { openingBalance = value; }
            get { return openingBalance; }
        }
        public SpecialCurrent()
        {
            Console.WriteLine("SpecialCurrent Created with default");
        }
        public SpecialCurrent(int openingBalance)
        {
            this.openingBalance = openingBalance;
            Console.WriteLine("SpecialCurrent Created with 1 parameter");
        }
    }
}
