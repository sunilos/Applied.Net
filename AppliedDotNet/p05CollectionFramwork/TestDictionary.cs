using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p05CollectionFramwork
{
    /* Test the Dictionary class.
     * @Author SunilOS
     */
    public class TestDictionary
    {
        public static void Test()
        {
            Dictionary<String, Int32> map = new Dictionary<String, Int32>();
            map.Add("One", 1); //Correct
            map["Two"] = 2; //Correct
            int a = map["One"];
            Console.WriteLine(a);
            /*foreach (KeyValuePair<string, decimal> kvp in salaryMap)
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);*/
        }
    }
}