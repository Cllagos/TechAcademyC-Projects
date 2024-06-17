using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            // Part 1
            //string[] stringArray = { "add text 1", "add text 2", "add text 3", "add text 4", "add text 5" };
            //Console.WriteLine("Please type in some text here.");
            //string userInput = Console.ReadLine();

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    string addToString = userInput + stringArray[i];
            //    stringArray[i] = addToString;
            //}

            //for (int j = 0; j < stringArray.Length; j++)
            //{
            //    Console.WriteLine(stringArray[j]);
            //}

            //Console.ReadLine();

            //Part 2

            //int[] intArray = { 0, 1, 2, 3, 4 };

            //bool isTrue = intArray.Length < 6;

            //while (isTrue)
            //{
            //    for (int i = 0; i < intArray.Length; i++)
            //    {
            //        Console.WriteLine("Infinite Loop");

            //    }
            //    isTrue = false;                          // Updated the isTrue boolean variable to false after the loop is finished to prevent infinite loop.
            //}
            //Console.ReadLine();


            //int[] intArray = { 0, 1, 2, 3, 4 };

            //bool isTrue = intArray.Length <= 6;

            //while (isTrue)
            //{
            //    for (int i = 0; i < intArray.Length; i++)
            //    {
            //        Console.WriteLine("Infinite Loop");

            //    }
            //    isTrue = false;                          // Updated the isTrue boolean variable to false after the loop is finished to prevent infinite loop.
            //}
            //Console.ReadLine();

            //List<string> stringList = new List<string> { "Brooklyn","Chicago","Milwaukee","Miami","New York"};

            //Console.WriteLine("Please enter a famous city.");
            //string userInput = Console.ReadLine();
            //bool stopLoop = true;
            //bool isInIndex = false;


            //while (stopLoop)
            //{
            //    for (int i = 0; i < stringList.Count; i++)
            //    {
            //        if (userInput == stringList[i])
            //        {
            //            Console.WriteLine("Name matched to: " + stringList[i]);
            //            isInIndex = true;
            //        }
            //        else if (userInput != stringList[i] && isInIndex == false)
            //        {
            //            isInIndex = false;
            //        }

            //    }
            //    if (isInIndex == false)
            //    {
            //        Console.WriteLine("Could not find match");
            //    }
            //    stopLoop = false;
            //    Console.WriteLine("Please enter another city.");
            //    userInput = Console.ReadLine();
            //    stopLoop = true;
            //}
            //Console.ReadLine();

            //List<string> newStringList = new List<string> { "John", "Jacob", "Matt", "Erik", "John" };
            //Console.WriteLine("Please enter a common men's first name.");
            //string userInput = Console.ReadLine();
            //int stringIndex = 0;
            //int countOfMatches = 0;

            //foreach (string i in newStringList) 
            //{
            //    if (userInput == i && countOfMatches == 0)
            //    {
            //        stringIndex = newStringList.IndexOf(i);
            //        countOfMatches += 1;
            //        Console.WriteLine("Matched Name of " + i);
            //        Console.WriteLine("Index Of Match Found: " + stringIndex);

            //    }
            //}
            //if (countOfMatches == 0)
            //{
            //    Console.WriteLine("No Matches Found.");
            //}

            //Console.ReadLine();

            List<string> newStringList = new List<string> { "John", "Jacob", "Matt", "Erik", "John" };
            List<string> countOfMatches = newStringList;
            int matchedName = 0;


            foreach (string i in newStringList)
            {
    
                matchedName = 0;
              for (int j = 0; j < newStringList.Count; j++)
                {
                    if (countOfMatches[j] == i)
                    {
                        matchedName += 1;
                    }

                }
              if (matchedName == 1)
              {
                  Console.WriteLine(i + " This is a unique name.");
              }
              else if (matchedName > 1)
              {
                  Console.WriteLine(i + " This is a duplicate name.");
              }

            }
            Console.ReadLine();

        }
    }
}
