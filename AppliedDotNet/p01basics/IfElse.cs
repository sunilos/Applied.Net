﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class IfElse
    {
        public static void Else(String[] args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine("Hello " + args[0]);
            }
            else
            {
                Console.WriteLine("Usage : HelloName <name>");
            }
        }
    }
}