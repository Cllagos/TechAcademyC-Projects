using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWWelcom back {uName}.  Today is {date}";

            Console.WriteLine(msg);

            string path = @"C:\Users\clagos\OneDrive - IPG Photonics\Attachments\TechAcademyC#Repo\Scores\Scores\studentScores.txt";
            double tScore = 0.0;
            string[] lines = System.IO.File.ReadAllLines(path);

            Console.WriteLine("\nStudent Scores:   \n");

            foreach( string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;

            }
            double averageScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \t Aversage score: " + averageScore);
            
            Console.WriteLine("\n\nPress any key to exit.");

            Console.ReadLine();
        }
    }
}
