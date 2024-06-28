using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethods
{
    public class Method
    {
        public Method() 
            {

            Property = 0;
                
            }

        public int Function(int parameter)
        {
            parameter += 1;
            return parameter;
        }
        public decimal Function(decimal parameter, int multiply)
        {
            parameter = parameter * multiply;
            return parameter;
        }

        public int Function(string parameter, out int outInteger, int divide)
        {
            
            int newInteger = Convert.ToInt32(parameter);
            outInteger = (newInteger/divide);

            return outInteger;
        }


        public int Property { get; set; }


    }
}
