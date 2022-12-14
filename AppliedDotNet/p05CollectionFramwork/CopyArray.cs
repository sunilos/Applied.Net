using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    public class CopyArray
    {
        public static void Test()
        {
            ArrayList list = new ArrayList(5);
            list.Add("Hira");
            list.Add("Moti");
            
            string[] strArray = new string[list.Count];
            list.CopyTo(strArray, 0);
            
            Object[] objArray = list.ToArray();
            
            string[] strArray2 = (string[])list.ToArray(typeof(String));
            foreach (string s in strArray) //Or objArray, strArray2
            {
                Console.WriteLine(s);
            }
        }
    }
}