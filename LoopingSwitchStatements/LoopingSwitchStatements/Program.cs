using System;


namespace LoopingSwitchStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            bool isGuessedRight = newNumber == 50;


            do
            {

                switch (newNumber)
                {
                    case 1:
                        Console.WriteLine("You guessed 1, that is the wrong number.");
                        Console.WriteLine("Guess a number");
                        newNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("You guessed 5, that is the wrong number.");
                        Console.WriteLine("Guess a number");
                        newNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed 10, that is the wrong number.");
                        Console.WriteLine("Guess a number");
                        newNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 50:
                        Console.WriteLine("You guessed the right numer!");
                        isGuessedRight = true;
                        break;


                    case 100:
                        Console.WriteLine("You guessed 100, that is the wrong number.");
                        Console.WriteLine("Guess a number");
                        newNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("You guessed the wrong number.");
                        Console.WriteLine("Guess a number");
                        newNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessedRight);

            Console.ReadLine();
        }
    }
}
