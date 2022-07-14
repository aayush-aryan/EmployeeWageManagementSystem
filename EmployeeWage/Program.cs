using System;

namespace EmployeeWage
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Management System ");
            Employee.CalculatingTotalMonthlyWagesForMultipleCompany("Reliance", 20,20,100);
            Employee.CalculatingTotalMonthlyWagesForMultipleCompany("Tata", 30, 20, 120);
        }
    }
}
