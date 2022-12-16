using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    /* Tests propagation of unchecked exception .
     * @Author SunilOS
     */
    public class FamilyNoOne
    {
        public static void Test()
        {
            Padosi();
        }
        public static void Padosi()
        {
            Dad();
        }
        public static void Dad()
        {
            Mom();
        }
        /*public static void Mom()
         {
             Raju();
         }*/
        public static void Mom()
        {
            try
            {
                Raju();
            }
            catch (LoginException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*public static void Raju()
        {
            LoginException e = new LoginException("I lost Rs 500");
            throw e;
        }*/
        public static void Raju()
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