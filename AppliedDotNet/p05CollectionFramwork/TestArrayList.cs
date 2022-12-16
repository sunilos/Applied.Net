using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Test the ArrayList class.
     * @Author SunilOS
     */
    public class TestArrayList
    {
        public static void Test()
        {
            ArrayList al = new ArrayList();

            al.Add("Jay");

            al.Add("Vijay");

            al.Add("Viru");

            //By ForeachLoop
            foreach (string e in al)
            {
                Console.WriteLine(e);
            }
            //By ForLoop
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}