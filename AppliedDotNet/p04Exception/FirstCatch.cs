using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class FirstCatch
    {
        public static void Test()
        {
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