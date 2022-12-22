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
    public class TestWithThread
    {
        public static void Test()
        {
            HelloWithThread shubham = new HelloWithThread("Shubham");
            HelloWithThread vaibhav = new HelloWithThread("Vaibhav");
            
            ThreadStart ts = new ThreadStart(shubham.Run);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(new ThreadStart(vaibhav.Run));
            
            t1.Start();
            t2.Start();
            bool a = t1.IsBackground; // Background threads are terminated when application ends.
            bool b = t1.IsAlive;      // Has thread started but not terminated.

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;    

            for (int i = 0; i <= 500; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(t1.ThreadState);  // Unstarted, Running, Suspended, Stopped, WaitSleepJoin.
                Console.WriteLine(i + " Main Thread ");
            }
        }
    }
}