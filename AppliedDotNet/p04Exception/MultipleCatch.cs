using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    /* Example of one try and multiple catch blocks.
     * @Author SunilOS
     */
    public class MultipleCatch
    {
        public static void Test()
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
            try
            {
                String name = "Vijay Dinanth Chohan";
                Console.WriteLine(name.Length);
                Console.WriteLine(name[6]);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}