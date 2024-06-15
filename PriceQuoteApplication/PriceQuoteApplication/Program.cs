using System;


namespace PriceQuoteApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcom to Package Express");
            Console.WriteLine("\r");
            Console.WriteLine("Please enter the package weight.");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            string response = pkgWeight > 50 ? "Package too heavy to be shipped via Package Express" : "What is your package width?";

            Console.WriteLine(response);
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            if (pkgWidth > 50 || pkgHeight > 50 || pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
            }
            else
            {
                decimal priceQuote = ((pkgHeight * pkgWidth * pkgLength) * pkgWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + Convert.ToString(priceQuote));
                Console.ReadLine();
            }




        }
    }
}
