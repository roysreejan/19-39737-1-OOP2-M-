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
            Console.WriteLine("Savings: ");
            Savings s1 = new Savings("Sreejan Roy", "19397371", 5000);
            Savings s2 = new Savings("Sojib", "19397372", 5500);
            s1.Withdraw(500);
            s1.Deposit(1000);
            s1.Transfer(1000, s2);

            s1.ShowInfo();
            s2.ShowInfo();

            Console.WriteLine("**********************");

            Console.WriteLine("Special:");
            SpecialCurrent sc1 = new SpecialCurrent("Sreejan Roy", "19397371", 5000);
            SpecialCurrent sc2 = new SpecialCurrent("Sojib", "19397372", 5500);
            sc1.Withdraw(500);
            sc1.Deposit(1000);
            sc1.Transfer(5000, sc2);

            sc1.ShowInfo();
            sc2.ShowInfo();

            Console.WriteLine("**********************");
           
            Console.WriteLine("Fixed: ");
            Fixed f1 = new Fixed("Sreejan Roy", "19397371", 5000, 4);
            Fixed f2 = new Fixed("Sojib", "19397372", 5500, 3);
            f1.Withdraw(500);
            f1.Deposit(1000);
            f1.Transfer(5000, f2);

            f1.ShowInfo();
            f2.ShowInfo();

            Console.WriteLine("**********************");
            
            Console.WriteLine("OverDraft: ");
            OverDraft od1 = new OverDraft("Sreejan Roy", "19397371", 5000);
            OverDraft od2 = new OverDraft("Sojib", "19397372", 5500);
            od1.Withdraw(500);
            od1.Deposit(1000);
            od1.Transfer(5000, od2);

            od1.ShowInfo();
            od2.ShowInfo();
        }
    }
}
