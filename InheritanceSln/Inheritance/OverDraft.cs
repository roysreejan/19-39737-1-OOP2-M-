using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class OverDraft : Account
    {
        private int limit = 50000;

        public OverDraft()
        {
            Console.WriteLine("OverDraft Account created with default");
        }
        public OverDraft(string accName, string accid, int balance)
            : base(accName, accid, balance)
        {
            base.Balance = balance + this.Limit;
        }

        public int Limit
        {
            get { return this.limit; }
        }

        public override void Withdraw(int amount)
        {
            if (this.Balance >= amount)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine(" You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }

        public override void Deposit(int amount)
        {
            base.Deposit(amount);
        }

        public override void Transfer(int amount, Account acc)
        {
            if (base.Balance >= amount)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine(" You've exceeded your minimum balance!!");
                Console.WriteLine();
            }
        }
    }
}
