﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p02VariableOparetors
{
    public class SmallToBig
    {
        public static void DataType()
        {
            int i = 5;
            double d = i;

            Console.WriteLine(d);

            short s = 10;
            int j = s;
            long l = j;

            Console.WriteLine(j);
            Console.WriteLine(s);

        }
    }
}