using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
    * TestSynchronizationMoniter to thread(s), waiting for acquiring lock (monitor) on Message object.
    * @Author SunilOS
    */
    public class TestSychronizationMoniter
    {
        public static void Test()
        {
            SynchronizationMoniter sm = new SynchronizationMoniter();
            
            sm.SetBalance(1400000);
            sm.deposit("Withdrwal", 40000);

            Console.WriteLine(sm.GetBalance());
        }
    }
}
