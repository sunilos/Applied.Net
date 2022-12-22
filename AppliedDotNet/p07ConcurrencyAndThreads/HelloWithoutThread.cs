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
    public class HelloWithoutThread
    {
        String name = null; // Keeps Thread Name
        public HelloWithoutThread(String threadName)  // Constructor
        {                                              
            name = threadName;
        }
        public void Run()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i + " Hello Thread " + name);
            }
        }
    }
}
