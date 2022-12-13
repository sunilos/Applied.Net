using DocumentFormat.OpenXml.Wordprocessing;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class ParentsException
    {
        public static void exception()
        {
            try
            {
                String name = "Vijay Dinanath Chohan";
                Console.WriteLine(name.Length);
                Console.WriteLine(name[6]);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}