using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaining_Constructors
{
    public class ChainedConstructors
    {

        public string variable1;
        public string variable2;
        public ChainedConstructors() : this("ID") 
        {

        }
        public ChainedConstructors(string variable1) : this(variable1, "Name")
        {

        }
        public ChainedConstructors(string variable1, string variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;

        }

        public static string variableFuction(string variable2)
        {
            Console.WriteLine("This is the name of the user {0}", variable2);
            return variable2;
        }

    }
}
