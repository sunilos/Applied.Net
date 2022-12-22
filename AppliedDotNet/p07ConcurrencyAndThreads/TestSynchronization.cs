using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     * TestSynchronization object releases the lock from the Message object by calling
     * deposite() method and wait until Test by TestSychronization.
     * 
     * @Author SunilOS
     */
    public class TestSynchronization
    {
        public static void Test()
        {
            Synchronization s = new Synchronization();
            s.SetBalance(120000);
            s.deposit("Gift for Birthday Celebration", 5000);
            Console.WriteLine(s.GetBalance());
        }
    }
}