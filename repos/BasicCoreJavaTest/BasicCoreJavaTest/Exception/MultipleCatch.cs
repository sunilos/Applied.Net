using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.Exception
{
    internal class MultipleCatch
    {
        public static void Catch()
        {
            int a, b = 0;
            Console.WriteLine("My program starts");
            try
            {
                a = 10 / b;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
