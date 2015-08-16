using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interest, int period)
            : base(customer, balance, interest, period)
        { }

        public void WithdrowMoney(decimal withdrow)
        {
            if (this.Balance < withdrow)
            {
                Console.WriteLine("You donot have sufficient amount of money in your account!");
            }
            else
            {
                this.Balance -= withdrow;
            }
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0m;
            }
            else
            {
                return base.CalculateInterestAmount();
            }
        }
    }
}
