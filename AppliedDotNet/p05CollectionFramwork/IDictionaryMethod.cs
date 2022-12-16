using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Test IDictionaryMethod class.
     * @Author SunilOS
     */
    public class IDictionaryMethod
    {
        public static void Test()
        {
            IDictionary id = new Hashtable();

            id.Add(1, "Shubham Kumawat");
            id.Add(2, "Vaibhav Gehlot");
            id.Add(3, "Aniket Kumawat");

            //id.Clear();
            //id.Remove(3);
            Console.WriteLine(id.Contains(1));

            IDictionaryEnumerator e = id.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("{0} ={1}", e.Key, e.Value);
                //Console.WriteLine(e.Key + “ = ” + e.Value);
            }
        }
    }
}