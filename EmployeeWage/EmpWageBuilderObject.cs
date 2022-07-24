using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        /// <summary>
        /// parametrised constructor 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        /// <summary>
        /// method for computing total wages
        /// </summary>
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmphrs = 0, totalWorkingDays = 0;
            while (totalEmphrs<=this.maxHoursPerMonth && totalWorkingDays<this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                         break;
                }
                totalEmphrs = totalEmphrs + empHrs;
                Console.WriteLine("Days#:"+ totalWorkingDays + "Emp hrs :" + empHrs);
            }
            totalEmpWage = totalEmphrs * this.empRatePerHour;
            Console.WriteLine("totalEmpWage for company :" + company+"is :"+ totalEmpWage);
        }
        /// <summary>
        /// Tostring method that converts object to sting
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Total Emp Wage for Company :"+ this.company + "is :" +this.totalEmpWage;
        }
          
    }
}