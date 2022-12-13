using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class TryCatch
    {
        public static void Try()
        {
            int a, b = 0;
            Console.WriteLine("My program starts ");
            try
            {
                a = 10 / b; //Cause divided by zero exception
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Remaining program");
        }
    }
}