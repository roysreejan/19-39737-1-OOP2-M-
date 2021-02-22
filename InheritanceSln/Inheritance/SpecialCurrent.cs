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
        private int minBalance;

        public SpecialCurrent()
        {
            Console.WriteLine("SpecialCurrent Account created with default");
        }
        public SpecialCurrent(string accName, string accid, int balance) : base(accName, accid, balance)
        {
            this.OpeningBalance = balance;
            minBalance = (openingBalance * 10) / 100;
        }
        public int OpeningBalance
        {
            set { openingBalance = value; }
            get { return openingBalance; }
        }
        public int MinBalance
        {
            get { return minBalance; }
        }

        public override void Withdraw(int amount)
        {
            if (this.MinBalance < this.Balance - amount)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }

        public override void Deposit(int amount)
        {
            base.Deposit(amount);
        }

        public override void Transfer(int amount, Account acc)
        {
            if (this.MinBalance < base.Balance - amount)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }
    }
}
