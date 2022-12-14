using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p02VariableOparetors
{
    public class IncrementDecrement
    {
        public static void Test()
        {
            int i = 0;
            Console.WriteLine(++i + ++i + ++i + ++i + ++i + ++i);
            Console.WriteLine("" + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i + " " + ++i);

        }
    }
}