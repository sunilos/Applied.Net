﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    /* Tests Finally block to cleanup resources.
     * @Author SunilOS
     */
    public class TestFinally
    {
        public static void Test()
        {
            int a;
            int b = 0;
            Console.WriteLine("My program starts");
            try
            {
                a = 10 / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("I am Pandit");
            }
        }
    }
}