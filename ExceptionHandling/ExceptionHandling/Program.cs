using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numList = new List<int> { 1, 2, 3, 4, 5 };
                Console.WriteLine("Please enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int i in numList)
                {
                    int result = userInput / i;
                    Console.WriteLine(userInput + " divided by " + i + " = " + result);
                }
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Please use a number and not text");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }

            finally
            {
                Console.ReadLine();
            }
           

        }
    }
}
