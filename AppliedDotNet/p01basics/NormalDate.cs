using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Program to get the Date
     * @Author SunilOS
     */
    public class NormalDate
    {
        public static void Test()
        {

            /*Console.WriteLine(DateTime.Now);*/


            //*  Maintain the date of mobile recharge  *//

            /*DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Now.AddDays(-10);
            DateTime d3 = DateTime.Now.AddDays(10);

            Console.WriteLine(d2);
            Console.WriteLine(d3);*/


            //*  Change the Date to String Format  *//

            /*DateTime dt = DateTime.Now;

            String sdt = dt.ToString("dd/MM/yyyy");
            
            Console.WriteLine("ToString: " + sdt);*/


            //*  Change the String to Date Format  *//

            /*String dob = "17/10/2002";
            DateTime newDob = DateTime.Parse(dob);
            Console.WriteLine(newDob);*/


            //*  Today's Date Program with Time  *//

            /*DateTime Day = DateTime.Now;

            Console.WriteLine(Day);
            TimeSpan Month = new System.TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAMonth = Day.Add(Month);
            DateTime aDayBeforeAMonth = Day.Subtract(Month);
            Console.WriteLine("{0:dddd}", aDayAfterAMonth);
            Console.WriteLine("{0:dddd}", aDayBeforeAMonth);*/


            //*  Date Method  *//

            /*DateTime DateTimeProperty = new DateTime(1974, 10, 25, 7, 10, 24); // Year Month Date Hours Minutes Seconds

             Console.WriteLine("Month:{0}", DateTimeProperty);
             Console.WriteLine("Day:{0}", DateTimeProperty.Day);
             Console.WriteLine("Month:{0}", DateTimeProperty.Month);
             Console.WriteLine("Year:{0}", DateTimeProperty.Year);
             Console.WriteLine("Hour:{0}", DateTimeProperty.Hour);
             Console.WriteLine("Minute:{0}", DateTimeProperty.Minute);
             Console.WriteLine("Second:{0}", DateTimeProperty.Second);
             Console.WriteLine("Millisecond:{0}", DateTimeProperty.Millisecond);
             Console.WriteLine("Day of Week:{0}", DateTimeProperty.DayOfWeek);
             Console.WriteLine("Day of Year: {0}", DateTimeProperty.DayOfYear);
             Console.WriteLine("Time of Day:{0}", DateTimeProperty.TimeOfDay);
             Console.WriteLine("Tick:{0}", DateTimeProperty.Ticks);
             Console.WriteLine("Kind:{0}", DateTimeProperty.Kind);*/
        }
    }
}