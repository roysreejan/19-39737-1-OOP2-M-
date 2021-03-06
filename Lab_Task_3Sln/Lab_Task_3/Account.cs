﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        //properties
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        //constructor
        public Account()
        {
            Console.WriteLine("\nAccount created with default");
        }
        public Account(string accName, string acid, int balance)
        {
            Console.WriteLine("Account created with 3 parameter");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            this.balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine("Error: Amount is higher than balance!!");
            }
            else
            {
                this.balance -= amount;
            }
        }
    }
}
