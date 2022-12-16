using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Program to CollectionSequentially and test the Enumerator in this class.
     * @Author SunilOS
     */
    public class CollectionSequentially
    {
        public static void Test()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Shubham");
            myQ.Enqueue("Kumawat");

            IEnumerator en = myQ.GetEnumerator();
            while (en.MoveNext())
            {
                Console.Write("\t{0}", en.Current);
            }
        }
    }
}