using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("To get approved for insurance, you must answer these questions below:");
            Console.WriteLine("\r");
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            double doubleAge = Convert.ToDouble(ageInput);
            Console.WriteLine("Have you ever had a DUI? Yes or No");
            string duiInput = Console.ReadLine();
            bool boolDUI = duiInput == "No" || duiInput == "no";
            Console.WriteLine("Have many speeding tickets have you had?");
            string ticketInputt = Console.ReadLine();
            double doubleTicket = Convert.ToDouble(ticketInputt);
            bool ticketAmt = doubleTicket < 3;
            bool isQualified = doubleAge > 15 && boolDUI && ticketAmt;

            Console.WriteLine("Are you qualified? " + isQualified.ToString());
            Console.ReadLine();


        }
    }
}
