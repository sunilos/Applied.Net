using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.Variable_and_Oparetors
{
    internal class And_OR
    {
        public static void ORAND()
        {
            int i = 0;
            System.Console.WriteLine("Test:" + ((2 < 3) || (0 < i++)));
            System.Console.WriteLine("I:" + i);

            System.Console.WriteLine("Test:" + ((2 < 3) && (0 < i++)));
            System.Console.WriteLine("I:" + i);
        }

    }
}
