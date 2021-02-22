using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.AccName = "Sreejan Roy";
            a1.Acid = "19397371";
            a1.Balance = 10000;

            a1.Deposit(1000);
            Console.WriteLine("After Deposit: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a1.AccName, a1.Acid, a1.Balance);

            a1.Withdraw(500);
            Console.WriteLine("After Withdraw: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a1.AccName, a1.Acid, a1.Balance);

            Account a2 = new Account("Sreejan Roy", "152375", 50000);
            a2.Deposit(1000);
            Console.WriteLine("After Deposit: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a2.AccName, a2.Acid, a2.Balance);

            a2.Withdraw(500);
            Console.WriteLine("After Withdraw: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}", a2.AccName, a2.Acid, a2.Balance);
        }
    }
}
