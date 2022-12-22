using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     * Tread access the Account object and raise a racing condition. Account resolve
     * the racing condition by synchronized deposit method.
     * 
     * @Author SunilOS
     */
    public class RacingCondThread
    {
        public static Account data = new Account();
        String name = null;
        public RacingCondThread(String name)
        {
            this.name = name;
        }
        public void Run()
        {
            for (int i = 0; i <= 5; i++)
            {
                data.Deposit(name, 1000);
            }
        }
    }
}
