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

        public static int empCheck;
        public static int empHrs;
        public static int empWage;


        public static int RandomIntegerGenerator(int minRange, int maxRange)
        {
            Random random = new Random();
            empCheck = random.Next(minRange, maxRange);
            return empCheck;
        }

        public static void AddingPartTimeEmployeeWagesUsingSwitchCase()
        {
            
            empCheck = Employee.RandomIntegerGenerator(0,3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Full Time");
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is Part Time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wages :" + empWage);
        }
    }

}
