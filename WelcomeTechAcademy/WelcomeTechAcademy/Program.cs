using System;

namespace WelcomeTechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("\r");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string stringNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(stringNumber);
            Console.WriteLine("Do you need help with anything? True or False");
            string trueFalse = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you would like to provide?");
            string responeExperience = Console.ReadLine();
            Console.WriteLine("Is there any feedback that you would like to provide?");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("Thank you for you answers!  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();




        }
    }
}
