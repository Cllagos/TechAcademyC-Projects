using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringsProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This app will concatenate strings");
            Console.WriteLine("Please enter a sentence.");
            string firstSentence = Console.ReadLine();
            Console.WriteLine("Please enter a new sentence.");
            string secondSentence = Console.ReadLine();
            Console.WriteLine("Please enter a new sentence.");
            string thirdSentence = Console.ReadLine();
            string resultSentence = firstSentence + "\n" + secondSentence + "\n" + thirdSentence;
            Console.WriteLine("Result Sentences: " +"\n" + resultSentence);
            Console.WriteLine("Sentences now in uppercase: " +"\n" + resultSentence.ToUpper());

            StringBuilder newSentences = new StringBuilder();
            Console.WriteLine("Building sentences with string builder");
            newSentences.Append(firstSentence);
            Console.WriteLine(newSentences);
            Console.WriteLine("Building sentences with string builder");
            newSentences.Append(secondSentence);
            Console.WriteLine(newSentences);
            Console.WriteLine("Building sentences with string builder");
            newSentences.Append(thirdSentence);
            Console.WriteLine(newSentences);
            Console.ReadLine();


        }
    }
}
