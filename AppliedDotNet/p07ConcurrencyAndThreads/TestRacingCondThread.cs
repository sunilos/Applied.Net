using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     * Tread access the Account object and raise a racing condition.
     * @Author SunilOS
     */
    public class TestRacingCondThread
    {
        public static void Test()
        {
            RacingCondThread s = new RacingCondThread("Shubham");
            RacingCondThread v = new RacingCondThread("Vaibhav");
            
            Thread t1 = new Thread(new ThreadStart(s.Run));
            Thread t2 = new Thread(new ThreadStart(v.Run));
            
            t1.Start();
            t2.Start();
        }
    }
}
