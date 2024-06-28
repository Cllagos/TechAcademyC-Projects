using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int newNumber = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\clagos\Documents\VisualStudioLog\number.txt", true))
            {
                file.WriteLine(newNumber);
            }

            string loggedNumber = File.ReadAllText(@"C:\Users\clagos\Documents\VisualStudioLog\number.txt");
            Console.WriteLine("This is the text in number log file: \n" + loggedNumber);
            
            Console.ReadLine();
        }
    }
}
