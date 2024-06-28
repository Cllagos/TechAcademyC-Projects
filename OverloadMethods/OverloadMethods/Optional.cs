using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    class Optional
    {
        public int optionalFunction(int parameter, int multiplier = 2)
        {

            int result = parameter * multiplier;

            return result;

        }
    }
}
