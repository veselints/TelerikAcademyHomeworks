using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Mortgage : Account
    {
        private int MonthsWithDicountInterestForCompanies = 12;
        private decimal DiscountForCompanies = 0.5m;
        private int MonthsWithDicountInterestForIndividuals = 6;

        public Mortgage(Customer customer, decimal balance, decimal interest, int period)
            : base(customer, balance, interest, period)
        { }

        public override decimal CalculateInterestAmount()
        {
            if (this.Customer == Customer.company)
            {
                if (this.PeriodInMonths <= MonthsWithDicountInterestForCompanies)
                {
                    return base.CalculateInterestAmount() * DiscountForCompanies;
                }
                else
                {
                    decimal interestCompaniesTwelveMontsPlus =
                        (MonthsWithDicountInterestForCompanies * this.MonthlyInteresRate * this.Balance) +
                        ((this.PeriodInMonths - MonthsWithDicountInterestForCompanies) * this.MonthlyInteresRate * this.Balance);
                    return interestCompaniesTwelveMontsPlus;
                }
            }
            else
            {
                if (this.PeriodInMonths <= MonthsWithDicountInterestForIndividuals)
                {
                    return 0m;
                }
                else
                {
                    decimal interestIndividualsSixMontsPlus =
                        ((this.PeriodInMonths - MonthsWithDicountInterestForIndividuals) * this.MonthlyInteresRate * this.Balance);
                    return interestIndividualsSixMontsPlus;
                }
            }
        }
    }
}
