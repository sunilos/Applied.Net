using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Test the Hashtable interface and its concrete class.
     * @Author SunilOS
     */
    public class TestHashtable
    {
        public static void Test()
        {
            IDictionary ht = new Hashtable();

            //IDictionary ht = new Hashtable(100);
            // Add elements to the table 

            ht.Add("house", "Dwelling"); //Insert Key/Value
            ht.Add("car", "Means of transport");
            ht.Add("apple", "Edible fruit");
            ht["tractor"] = "farm implement"; //set

            Console.WriteLine(ht["tractor"]); //get

            ICollection keys = ht.Keys;

            ICollection values = ht.Values;

            int[] marks = { 100, 90, 80 };
            ht.Add("A1", marks);
            int[] marks2 = { 90, 91, 80 };
            ht.Add("A2", marks2);

            marks = (int[])ht["A2"];

            IDictionaryEnumerator e = ht.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("{0} ={1}", e.Key, e.Value);
                //Console.WriteLine(e.Key + " = " + e.Value);
            }
        }
    }
}