using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    public class TestIListMethod
    {
        public static void Test()
        {
            IList al = new ArrayList();

            //IList al = new ArrayList(10);
            al.Add("Jay");
            al.Add("Viru");
            al.Add(5);
 
            al.Insert(1, "Vijay");//Insert at given Index
            al.Remove("Vijay"); //Remove Vijay
            al.RemoveAt(1); //Remove Ele at 1st Index
            al.IndexOf("new");
            al.Contains("Happy");
            /*al.Clear();*/

            Console.WriteLine(al);
            Console.WriteLine(al.Count); //Total Number of Elements
            Console.WriteLine(al[1]); //Get an element by Index
            Console.WriteLine(al.GetType()); //Get type of an Elementx
        }
    }
}