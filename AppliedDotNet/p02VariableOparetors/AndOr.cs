using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p02VariableOparetors
{
    public class AndOr
    {
        public static void Test()
        {
            int i = 0;
            System.Console.WriteLine("Test:" + ((2 < 3) || (0 < i++)));
            System.Console.WriteLine("I:" + i);

            System.Console.WriteLine("Test:" + ((2 < 3) && (0 < i++)));
            System.Console.WriteLine("I:" + i);
        }
    }
}