using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class TestFinally
    {
        public static void Finally()
        {
            int a;
            int b = 0;
            Console.WriteLine("My program starts");
            try
            {
                a = 10 / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("I am Pandit");
            }
        }
    }
}