using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter digits only, no decimals.");
                }
            }
            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using(StreamWriter file = new StreamWriter(@"C:\Users\clagos\Documents\VisualStudioLog\log.txt",true))

                {
                    file.WriteLine(player.Id);
                }
                
                Game game = new TwentyOneGame();            // Polymorphism
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >= 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occured.  Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now");
            Console.ReadLine();


        }
    }
}
