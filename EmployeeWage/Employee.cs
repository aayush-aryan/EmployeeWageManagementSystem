using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int Max_Hrs_IN_MONTH = 100;

        public static int empCheck;
        public static int empHrs = 0;
        public static int empWage = 0;
        public static int totalEmpWages = 0;
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;

        public static int RandomIntegerGenerator(int minRange, int maxRange)
        {
            Random random = new Random();
            empCheck = random.Next(minRange, maxRange);
            return empCheck;
        }

        public static void CalculatingTotalMonthlyWages()
        {

            while (totalEmpHrs <= Max_Hrs_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                empCheck = Employee.RandomIntegerGenerator(0, 3);

                switch (empCheck)
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
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day# :" + totalWorkingDays + "EmpHrs :" + empHrs);

            }
            int totalEmpWages = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("totalEmpWages :" + totalEmpWages);

        }
    }
}