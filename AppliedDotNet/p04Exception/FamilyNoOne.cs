using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class FamilyNoOne
    {
        public static void Test()
        {
            padosi();
        }
        public static void padosi()
        {
            dad();
        }
        public static void dad()
        {
            mom();
        }
        /*public static void mom()
         {
             raju();
         }*/
        public static void mom()
        {
            try
            {
                raju();
            }
            catch (LoginException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*public static void raju()
        {
            LoginException e = new LoginException("I lost Rs 500");
            throw e;
        }*/
        public static void raju()
        {
            LoginException e1 = new LoginException("I lost Rs 500");
            try
            {
                throw e1;
            }
            catch (LoginException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}