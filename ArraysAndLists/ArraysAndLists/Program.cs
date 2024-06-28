using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] newArray = {"Carlos","Michelle","Vinny","Matteo"};
            int[] newArray1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
            int arrayNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please a number 1 through 5 to pick a number in the second array.");
            int arrayNum1 = Convert.ToInt32(Console.ReadLine());

            bool numSelected = arrayNum > 0;
            bool numSelected1 = arrayNum1 > 0;

            do
            {
                switch (arrayNum)

                {
                    case 0:
                        Console.WriteLine("You picked a number smaller than 1");
                        numSelected = false;
                        
                        break;

                    case 1:
                        
                        Console.WriteLine("You picked 1, which is the name: " + newArray[0]);
                        Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
                        arrayNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        
                        Console.WriteLine("You picked 2, which is the name: " + newArray[1]);
                        Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
                        arrayNum = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 3:
                        
                        Console.WriteLine("You picked 3, which is the name: " + newArray[2]);
                        Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
                        arrayNum = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 4:
                        
                        Console.WriteLine("You picked 4, which is the name: " + newArray[3]);
                        Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
                        arrayNum = Convert.ToInt32(Console.ReadLine());

                        break;
                    default:
                        
                        Console.WriteLine("You picked a number outside of the array.");
                        Console.WriteLine("Please a number 1 through 4 to pick a name in the array.");
                        arrayNum = Convert.ToInt32(Console.ReadLine());

                        break;
                }
            }

            while (numSelected);

            do
            {
                switch (arrayNum1)

                {
                    case 0:
                        Console.WriteLine("You picked a number smaller than 1");
                        numSelected1 = false;

                        break;

                    case 1:

                        Console.WriteLine("You picked 1.");
                        Console.WriteLine("Please a number 1 through 5 to pick a name in the array.");
                        arrayNum1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:

                        Console.WriteLine("You picked 2.");
                        Console.WriteLine("Please a number 1 through 5 to pick a name in the array.");
                        arrayNum1 = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 3:

                        Console.WriteLine("You picked 3");
                        Console.WriteLine("Please a number 1 through 5 to pick a name in the array.");
                        arrayNum1 = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 4:

                        Console.WriteLine("You picked 4");
                        Console.WriteLine("Please a number 1 through 5 to pick a name in the array.");
                        arrayNum1 = Convert.ToInt32(Console.ReadLine());

                        break;
                    default:

                        Console.WriteLine("You picked a number outside of the array.");
                        Console.WriteLine("Please a number 1 through 5 to pick a name in the array.");
                        arrayNum1 = Convert.ToInt32(Console.ReadLine());

                        break;
                }
            }

            while (numSelected1);

            Console.Read();

        }
    }
}
