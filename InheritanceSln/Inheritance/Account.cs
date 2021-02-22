using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account
    {
        private string accName;
        private string accid;
        private int balance;
        public Account() 
        {
            Console.WriteLine("Account created with default");
        }

        public Account(string accName, string accid, int balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public virtual void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public virtual void Withdraw(int amount)
        {
            balance = balance - amount;
        }
        public virtual void Transfer(int amount, Account acc)
        {
            balance = balance - amount;
            acc.Balance = acc.Balance + amount;
            Console.WriteLine("Balance Transfered.");
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Account Name: {0}", this.AccName);
            Console.WriteLine("Account ID: {0}", this.Accid);
            Console.WriteLine("Account Balance: {0}", this.Balance);
            Console.WriteLine("Account Type: {0}", this.GetType().ToString().Split('.')[1]);
            Console.WriteLine();
        }
    }
}