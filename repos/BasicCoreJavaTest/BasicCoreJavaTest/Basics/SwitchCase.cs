using MaxMind.GeoIP2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreJavaTest.exercise4._14
{
    public class SwitchCase
    {
        public static void Switch()
        {

            String country = "India";

            switch (country)
            {

                case "India":

                    Console.WriteLine("Language is Hindi");
                    break;

                case "England":

                    Console.WriteLine("Language is English");

                    break;

                default:

                    Console.WriteLine("Don‟t know language { 0}", country);

                    break;
            }
        }
    }
}