﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
   public class BankAccount
    {
        public int Balance { get; set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public bool Deposit(int amount)
        {
            Balance += amount;
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
