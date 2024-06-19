using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type in a number.");
            decimal newNumber = Convert.ToDecimal(Console.ReadLine());

            Number structNum = new Number();

            structNum.Amount = newNumber;

            Console.WriteLine("Struct Number: {0}", structNum.Amount);
            Console.ReadLine();

        }
    }
}
