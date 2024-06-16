using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] testScores = { 98, 99, 85, 70, 82, 34, 90, 94 };

            //    for (int i = 0; i < testScores.Length; i++)
            //    {
            //        if (testScores[i] > 85)
            //        {
            //            Console.WriteLine("Passing Test Score: " + testScores[i]);
            //        }
            //    }
            //    Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Jesse")
            //    //{
            //        Console.WriteLine(names[j]);
            //    //}
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(90);
            //testScores.Add(95);
            //testScores.Add(82);
            //testScores.Add(74);
            //testScores.Add(98);
            //testScores.Add(84);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing Test Score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() {"Jesse","Erik","Adam","Daniel"};

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine("Passing Test Scores Count: " + passingScores.Count());
            Console.ReadLine();




        }
    }
}
