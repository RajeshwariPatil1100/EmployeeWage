using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, partTime = 2, Emp_Rate_Per_Hrs = 20, empHrs = 0, empWage = 0;
            Random randomObj = new Random();
            int checkPresent = randomObj.Next(0, 3);
            Console.WriteLine("Random Number is " + checkPresent);
            if (checkPresent == fullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else if (checkPresent == partTime)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}