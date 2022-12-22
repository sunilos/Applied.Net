using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p07ConcurrencyAndThreads
{
    /** 
     *  Account class containing synchronized method and synchronized block.
     *  @Author SunilOS
     */
    public class Account
    {
        private int balance = 0;

        public void SetBalance(int balance)
        {
            Thread.Sleep(200); // Simulate Database Operation
            this.balance = balance;
        }
        public void Deposit(String msg, int amount)
        {
            int bal = GetBalance();
            SetBalance(bal + amount);
            Console.WriteLine(msg + "Now Bal is " + GetBalance());
        }
        public int GetBalance()
        {
            Thread.Sleep(200); // Simulate Database Operation
            return balance;
        }
    }
}