using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide an Integer Value");
            string intValue1 = Console.ReadLine();
            int convertInt1 = Convert.ToInt32(intValue1);
            int multiply1 = convertInt1 * 50;
            Console.WriteLine("Your number multiplied by 50 is " + multiply1.ToString());
            int addNum = convertInt1 + 25;
            Console.WriteLine("Your number plus 25 is " + addNum.ToString());
            double divideNum = convertInt1 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divideNum.ToString());
            bool compareNum = convertInt1 > 50;
            Console.WriteLine("Is your number greater than 50? " + compareNum.ToString());
            double remainNum = convertInt1 % 7;
            Console.WriteLine("Your remainder when divided by 7 is " + remainNum.ToString());
            Console.ReadLine();
        }
    }
}
