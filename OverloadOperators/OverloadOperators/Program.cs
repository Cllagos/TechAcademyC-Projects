using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee newEmployee1 = new Employee();
            Employee newEmployee2 = new Employee();

            newEmployee1.FirstName = "Carlos";
            newEmployee1.LastName = "Lagos";
            newEmployee1.ID = 1;

            newEmployee2.FirstName = "Jim";
            newEmployee2.LastName = "Bowen";
            newEmployee2.ID = 2;

            bool isMatch1;
            isMatch1 = newEmployee1 == newEmployee2;

            Console.WriteLine("Does Employee1 ID match Employee2 ID ");
            Console.WriteLine("Employee1 ID: " + newEmployee1.ID);
            Console.WriteLine("Employee2 ID: " + newEmployee2.ID);
            Console.WriteLine("Do they match? " + isMatch1);
            Console.ReadLine();



        }
    }
}
