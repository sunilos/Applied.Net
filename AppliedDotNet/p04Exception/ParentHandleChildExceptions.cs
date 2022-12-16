using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    /* Example of Parent exception class handling exceptions of child and class. hierarchy exceptions.
     * @Author SunilOS
     */
    public class ParentHandleChildExceptions
    {
        public static void Test()
        {
            try
            {
                String name = "Vijay Dinanath Chohan";
                Console.WriteLine(name.Length);
                Console.WriteLine(name[6]);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}