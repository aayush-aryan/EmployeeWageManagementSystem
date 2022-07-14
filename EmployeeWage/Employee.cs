using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public static int empCheck;
        public static int empHrs = 0;

        public static int RandomIntegerGenerator(int minRange, int maxRange)
        {
            Random random = new Random();
            empCheck = random.Next(minRange, maxRange);
            return empCheck;
        }

        public static int GetWorkingHours(int randamValue)
        {
            int empHrs = 0;

            switch (randamValue)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }

        public static int CalculatingTotalMonthlyWagesForMultipleCompany(string companyName, int empRatePerHour,
            int numOfWorkingDays, int maxHrsPerMonth)
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                empCheck = RandomIntegerGenerator(0, 3);
                empHrs = GetWorkingHours(empCheck);
                totalEmpHrs = totalEmpHrs + empHrs;
                if (totalEmpHrs > maxHrsPerMonth)
                {
                    totalEmpHrs = totalEmpHrs - empHrs;
                }
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("totalEmpWage :" + totalEmpWage);
            Console.WriteLine("Total Employee Wages Of " + companyName + ":" + totalEmpWage);
            return totalEmpWage;
        }

    }
}