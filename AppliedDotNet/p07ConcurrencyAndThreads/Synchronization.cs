using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     * Synchronization object releases the lock from the Message object by calling
     * deposite() method and wait until Test by TestSychronization.
     * 
     * @Author SunilOS
     */
    public class Synchronization
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
            lock (this)
            {
                int bal = GetBalance() + amount;
                SetBalance(bal);

                Console.WriteLine(msg + " Now bal is " + bal);
            }
        }
    }
}