using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    public class TestQueue
    {
        public static void Test()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Vijay");
            myQ.Enqueue("Anil Ambani");
            myQ.Enqueue("Amar Singh");

            String ele = (String)myQ.Dequeue();//Get and Remove
            
            Console.WriteLine("Got the element " + ele);
            
            ele = (String)myQ.Peek();//Get and DO NOT remove

            Console.WriteLine(myQ.Contains("shubham kumawat"));
            Console.WriteLine("Got the element " + ele);
            Console.WriteLine("Queue Size is {0} ", myQ.Count);
        }
    }
}