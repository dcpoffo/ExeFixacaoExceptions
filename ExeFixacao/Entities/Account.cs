using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExeFixacao.Execeptions;

namespace ExeFixacao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {}

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void WithDraw (double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Limite para saque ultrapassado. Limite: $"+WithDrawLimit.
                    ToString("F2",CultureInfo.InvariantCulture));
            }
            if (amount > Balance )
            {
                throw new DomainException("Não há saldo suficiente para saque. Saldo: $"+Balance.
                    ToString("F2",CultureInfo.InvariantCulture));
            }

            Balance -= amount;
        }
    }
}
