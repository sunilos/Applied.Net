using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class TestString
    {
        public static void Test()
        {
            try
            {
                String name = "Vijay Dinanath Chohan";
                String name1 = " ";

                Console.WriteLine(name.Length);
                Console.WriteLine(name1.Length);
                Console.WriteLine(name[55]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}