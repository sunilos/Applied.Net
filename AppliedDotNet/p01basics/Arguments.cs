﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class Arguments
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void Modulus(int a, int b)
        {
            Console.WriteLine(a % b);
        }
    }
}