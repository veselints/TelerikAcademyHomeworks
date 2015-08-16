using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public abstract class Account
    {
        Customer customer;
        decimal balance;
        decimal monthlyInteresRate;
        int periodInMonths;

        public Account(Customer customer, decimal balance, decimal interest, int period)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInteresRate = interest;
            this.PeriodInMonths = period;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
	        private set
            {
                try 
	            {
                    this.customer = value;
                }
	            catch (Exception e)
	            {
		
		            throw new ArgumentException(e.Message);
	            }
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                try 
	            {
                    this.balance = value;
                }
	            catch (Exception e)
	            {
		
		            throw new ArgumentException(e.Message);
	            }
            }
        }

        public decimal MonthlyInteresRate
        {
            get
            {
                return this.monthlyInteresRate;
            }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("The interest rate must be positive!");
                    }
                    this.monthlyInteresRate = value;
                }
                catch (Exception e)
                {

                    throw new ArgumentException(e.Message);
                }
            }
        }

        public int PeriodInMonths
        {
            get
            {
                return this.periodInMonths;
            }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("The period cannot be negative or zero!");
                    }
                    this.periodInMonths = value;
                }
                catch (Exception e)
                {

                    throw new ArgumentException(e.Message);
                }
            }
        }

        public void DepositMoney(decimal deposit)
        {
            this.Balance += deposit;
        }

        public virtual decimal CalculateInterestAmount()
        {
            decimal interestAmount = this.MonthlyInteresRate * this.PeriodInMonths * this.Balance;
            return interestAmount;
        }
    }
}
