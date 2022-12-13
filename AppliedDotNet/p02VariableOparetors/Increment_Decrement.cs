using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p02VariableOparetors
{
    public class Increment_Decrement
    {
        public static void IncDec()
        {
            int i = 0;
            Console.WriteLine(++i + ++i + ++i + ++i + ++i + ++i);
            Console.WriteLine("" + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i);

        }
    }
}