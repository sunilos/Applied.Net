using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     * SynchronizationMoniter to thread(s), waiting for acquiring lock (monitor) on Message object.
     * @Author SunilOS
     */
    public class SynchronizationMoniter
    {
        private int balance = 0;

        public void SetBalance(int balance)
        {
            Thread.Sleep(200); // Simulate Database Operation
            this.balance = balance;
        }
        public int GetBalance()
        {
            Thread.Sleep(200); // Simulate Database Operation
            return balance;
        }
        public void deposit(String msg, int amount)
        {
            Monitor.Enter(this);
            try
            {
                int bal = GetBalance() + amount;
                SetBalance(bal);
                Console.WriteLine(msg + "Now bal is " + bal);
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}