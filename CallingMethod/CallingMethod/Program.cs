using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate numberCalc = new Calculate();
            Console.WriteLine("Please Assign A Number to Multiply.");

            int newNumber = Convert.ToInt32(Console.ReadLine());
            numberCalc.Calc1 = newNumber;
            numberCalc.Calc2 = newNumber;
            numberCalc.Calc3 = newNumber;

            Console.WriteLine(numberCalc.Calculate1(numberCalc.Calc1));
            Console.WriteLine(numberCalc.Calculate2(numberCalc.Calc2));
            Console.WriteLine(numberCalc.Calculate3(numberCalc.Calc3));


            Console.ReadLine();


        }
    }
}
