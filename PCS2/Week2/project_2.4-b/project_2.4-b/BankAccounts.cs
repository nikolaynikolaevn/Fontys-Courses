﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2._4_b
{
    class BankAccounts
    {
        private int accountNr;
        private decimal balance;
        private string name;

        public int AccountNr
        {
            get { return accountNr; }
        }
        public decimal Balance
        {
            get { return balance; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BankAccounts(int newAccountNr, decimal newBalance, string newName)
        {
            accountNr = newAccountNr;
            balance = newBalance;
            name = newName;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
            }
        }
    }
}
