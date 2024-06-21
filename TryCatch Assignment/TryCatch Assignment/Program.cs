using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            string ageInput = Console.ReadLine();
            bool isValid = false;
            try
            {
                isValid = int.TryParse(ageInput, out int age);
                
                
                    if (age == 0 || age < 0 || !isValid)
                    {
                        throw new ArgumentException();
                       
                    }
                    else
                    {
                        DateTime currentDate = DateTime.Now;
                        DateTime birthDate = currentDate.AddYears(-age);

                        Console.WriteLine($"If you are {age} years old now, you were born in the year {birthDate.Year}.");
                    }
                    
                
            }
            
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid age entered. Please enter a valid number. Cannot be zero, decimals, or negative numbers.");
                Console.ReadLine();
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("An exception has occured, please see system administrator.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();

        }
    }
}
