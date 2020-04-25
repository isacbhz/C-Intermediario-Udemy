﻿using System;
using System.Collections.Generic;
using System.Text;
using Aula_145_Exercicios_TryCatch.Entities;

namespace Aula_145_Exercicios_TryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amout)
        {
            Balance += amout;
        }
        public void WithDraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if (Balance > amount && WithdrawLimit < amount)
            {
                throw new DomainException("Has balance, but withdrawal value limit was exceeded");
            }          
            
            Balance -=amount;
        }
    }
}
