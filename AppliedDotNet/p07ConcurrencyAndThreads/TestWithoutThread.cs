using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /**
     * An example class that does not have thread concept.
     * @Author SunilOS
     */
    public class TestWithoutThread
    {
        public static void Test()
        {
            HelloWithoutThread t1 = new HelloWithoutThread("Shubham");
            HelloWithoutThread t2 = new HelloWithoutThread("Vaibhav");
 
            t1.Run();
            t2.Run();
        }
    }
}
