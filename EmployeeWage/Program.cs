using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Management System ");
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 20, 3, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            Reliance.computeEmpWage();
            Console.WriteLine(Reliance.ToString());
        }
    }
}
