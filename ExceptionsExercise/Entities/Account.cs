using System;
using Exceptions_exercise.Entities.Exceptions;

namespace Exceptions_exercise.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new ApplicationException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new ApplicationException("Not enough balance");
            }

            Balance -= amount;

        }
    }
}
