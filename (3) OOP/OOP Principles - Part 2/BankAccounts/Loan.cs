using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Loan : Account
    {
        private int discountPeriodForIndividuals = 3;
        private int discountPeriodForCompanies = 2;

        public Loan(Customer customer, decimal balance, decimal interest, int period)
            : base(customer, balance, interest, period)
        { }

        public override decimal CalculateInterestAmount()
        {
            if (this.Customer == Customer.company)
            {
                if (this.PeriodInMonths <= discountPeriodForCompanies)
                {
                    return 0m;
                }
                else
                {
                    decimal interestCompaniesTwoMontsPlus =
                        ((this.PeriodInMonths - discountPeriodForCompanies) * this.MonthlyInteresRate * this.Balance);
                    return interestCompaniesTwoMontsPlus;
                }
            }
            else
            {
                if (this.PeriodInMonths <= discountPeriodForIndividuals)
                {
                    return 0m;
                }
                else
                {
                    decimal interestIndividualsThreeMontsPlus =
                        ((this.PeriodInMonths - discountPeriodForIndividuals) * this.MonthlyInteresRate * this.Balance);
                    return interestIndividualsThreeMontsPlus;
                }
            }
        }
    }
}
