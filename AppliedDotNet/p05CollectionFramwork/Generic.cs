using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Test the generic collections.
     * @Author SunilOS
     */
    public class Generic
    {
        public static void Test()
        {
            List<string> rollNo = new List<string>();
            rollNo.Add("A1");
            rollNo.Add("A2");

            IEnumerator en = rollNo.GetEnumerator();
            while (en.MoveNext())
            {
                Console.Write("\t{0}", en.Current);
            }

            Queue<string> rollNo1 = new Queue<string>();
            rollNo1.Enqueue("B1");
            rollNo1.Enqueue("B2");

            IEnumerator en1 = rollNo1.GetEnumerator();
            while (en1.MoveNext())
            {
                Console.Write("\t{0}", en1.Current);
            }

            SortedList<string, Int32> rollNo2 = new SortedList<string, Int32>();
            rollNo2.Add("C1", 1);
            rollNo2.Add("C2", 2);

            IEnumerator en2 = rollNo2.GetEnumerator();
            while (en2.MoveNext())
            {
                Console.Write("\t{0}", en2.Current);
            }
     
            Stack<string> st = new Stack<string>();
            st.Push("One");
            st.Push("Two");
            st.Push("Three");

            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());
        }
    }
}