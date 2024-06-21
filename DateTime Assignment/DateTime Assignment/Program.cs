using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current DateTime: " + currentDateTime);

            // Prompt user for input
            Console.WriteLine("Please enter a number of hours:");
            int hoursToAdd = Convert.ToInt32(Console.ReadLine());

            // Calculate future date and time
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);

            // Display future date and time
            Console.WriteLine("In {0} hours, it will be: {1}", hoursToAdd, futureDateTime);

            Console.ReadLine();
        }
    }
}
