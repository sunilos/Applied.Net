using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /**
     * An example thread class.
     * @Author SunilOS
     */
    public class HelloWithThread
    {
        private String name = null;
        public HelloWithThread(String threadName)
        {
            name = threadName;
        }
        public void Run()
        {
            for (int i = 0; i <= 500; i++)
            {
                Console.WriteLine(i + " Hello Thread " + name);
            }
        }
    }
}