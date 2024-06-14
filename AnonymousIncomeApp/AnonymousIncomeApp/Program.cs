using System;

namespace AnonymousIncomeApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\r");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly Wage?");
            string hourlyWage1 = Console.ReadLine();
            double convertHourlyWage1 = Convert.ToDouble(hourlyWage1);
            Console.WriteLine("How many hours worked per week?");
            string weeksWorked1 = Console.ReadLine();
            double convertWeeksWorked1 = Convert.ToDouble(weeksWorked1);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly Wage?");
            string hourlyWage2 = Console.ReadLine();
            double convertHourlyWage2 = Convert.ToDouble(hourlyWage2);
            Console.WriteLine("How many hours worked per week?");
            string weeksWorked2 = Console.ReadLine();
            double convertWeeksWorked2 = Convert.ToDouble(weeksWorked2);
            double annualSalary1 = convertHourlyWage1 * convertWeeksWorked1 * 52;
            double annualSalary2 = convertHourlyWage2 * convertWeeksWorked2 * 52;

            Console.WriteLine("Annual Salary For Person 1 is: $" + annualSalary1.ToString());
            Console.WriteLine("Annual Salary For Person 2 is: $" + annualSalary2.ToString());

            bool compareSalary = annualSalary1 > annualSalary2;

            Console.WriteLine("Does Person 1 Make More Than Person 2? " + compareSalary.ToString());
            Console.ReadLine();




        }
    }
}
