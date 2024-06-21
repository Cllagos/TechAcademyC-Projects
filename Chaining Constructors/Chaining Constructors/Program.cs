using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaining_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Name");
            string newString = Console.ReadLine();
            const string ID = "1";

            var createUser = new ChainedConstructors(ID,newString);


            Console.WriteLine(createUser.variable1);
            Console.WriteLine(createUser.variable2);

            ChainedConstructors.variableFuction(newString);

            Console.ReadLine();
                

        }
    }
}
