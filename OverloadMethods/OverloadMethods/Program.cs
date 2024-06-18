using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in a number");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            string newString = "5";
            int newInteger = 0;

            Method newMethod = new Method();
            Optional newOption = new Optional();

            Console.WriteLine(newMethod.Function(newNumber));
            Console.WriteLine(newMethod.Function(Convert.ToDecimal(newNumber), 5));
            Console.WriteLine(newMethod.Function(newString,out newInteger, 5));

            Console.WriteLine("Please enter a number for function");
            int functionNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can enter a new number or leave blank");
            string inputUser = Console.ReadLine();
            if (inputUser == "")
            {
                Console.WriteLine(newOption.optionalFunction(functionNumber));
                Console.ReadLine();
            }
            else if (inputUser != "")
            {
                int optionalNumber = Convert.ToInt32(inputUser);
                Console.WriteLine(newOption.optionalFunction(functionNumber,optionalNumber));
                Console.ReadLine();
            }
            

           

            Console.ReadLine();

        }
    }
}
