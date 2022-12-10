using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.Variable_and_Oparetors
{
    internal class BigToSmall
    {
        public static void DataType()
        {
            double d = 5;
            int i = (int)d;
            short s = (short)i;
            int I = 10;
            float f = (float)I;


            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(I);
            Console.WriteLine(f);
        }
    }
}
