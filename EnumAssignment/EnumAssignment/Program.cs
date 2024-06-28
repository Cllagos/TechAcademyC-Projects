using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Current Day of The Week");


            try
            {
                bool dayFound = false;
                string userDay = Console.ReadLine();
                for (int i = 0; i < 7; i++)
                {
                    daysOfTheWeek WeekDay = (daysOfTheWeek)i;

                    string Day = WeekDay.ToString();

                    if (Day == userDay)
                    {
                        dayFound = true;
                        
                    }


                }
                if (dayFound == true)
                {
                    Console.WriteLine("Day of the Week Found");
                    Console.ReadLine();

                }
                else
                {
                    throw new FormatException();
                }

                    
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter A Day Of The Week");
            }

            Console.ReadLine();


            
            

        }

        
    }
}
