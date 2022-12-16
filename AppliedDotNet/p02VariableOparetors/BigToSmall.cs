using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p02VariableOparetors
{
    /* Example to Test Primitive Data Types
     * @Author SunilOS
     */
    public class BigToSmall
    {
        public static void Test()
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