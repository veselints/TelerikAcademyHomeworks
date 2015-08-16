using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("The week salary must be greater than 0!");
                    }
                    else
                    {
                        this.weekSalary = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("The work hours per day must be greater than 0!");
                    }
                    else
                    {
                        this.workHoursPerDay = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public Worker(string firstName, string lastName, decimal salary, int hours)
         : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public decimal MoneyPerHour()
        {
            return (weekSalary / (5*workHoursPerDay));
        }

        public override string ToString()
        {
            return String.Format(this.FirstName + " " + this.LastName + " " + this.WeekSalary + " " + this.WorkHoursPerDay);
        }
    }
}
