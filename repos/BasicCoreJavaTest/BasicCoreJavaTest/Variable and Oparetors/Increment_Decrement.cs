using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.Variable_and_Oparetors
{
    internal class Increment_Decrement
    {
        public static void IncDec()
        {
            int i = 0;
            Console.WriteLine(++i + ++i + ++i + ++i + ++i + ++i);
            Console.WriteLine("" + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i);

        }
    }
}
