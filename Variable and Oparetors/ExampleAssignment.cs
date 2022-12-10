using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.Variable_and_Oparetors
{
    internal class ExampleAssignment
    {
        public static void Ass()
        {
            int result, val_1, val_2;
            result = (val_1 = 1) + (val_2 = 2);
            Console.WriteLine("val_1 = " + val_1);
            Console.WriteLine("val_2 = " + val_2);
            Console.WriteLine("result = " + result);
        }

    }
}
