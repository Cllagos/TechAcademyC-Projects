using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    public class Calculate
    {
        public Calculate()
        {
            Calc1 = 1;
            Calc2 = 1;
            Calc3 = 1;

        }

        public int Calc1 { get; set; }
        public int Calc2 { get; set; }
        public int Calc3 { get; set; }

        public int Calculate1(int Calc1)
        {
            Calc1 = Calc1 * 5;

            return Calc1;
        }
        public int Calculate2(int Calc2)
        {
            Calc2 = Calc2 * 10;

            return Calc2;
        }

        public int Calculate3(int Calc3)
        {
            Calc3 = Calc3 * 100;

            return Calc3;
        }
    }
}
