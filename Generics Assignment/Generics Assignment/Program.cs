using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> newEmployee = new Employee<string>();

            List<string> officeSupplies = new List<string>() { "table", "chair", "lamp", "bookshelf" };

            newEmployee.things = officeSupplies;

            Employee<int> newEmployee2 = new Employee<int>();

            List<int> thingsInRoom = new List<int>() { 1, 2, 3, 4, 5 };

            newEmployee2.things = thingsInRoom;

            foreach (string i in newEmployee.things)
            {
                Console.WriteLine("Office Supplies: " + i + "\n");
                
            }

            foreach (int i in newEmployee2.things)
            {
                Console.WriteLine("Quantity of Objects in Each Room: " + i + "\n");
                
            }
            Console.ReadLine();


        }
    }
}
