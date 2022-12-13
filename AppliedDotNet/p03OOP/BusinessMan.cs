﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class BusinessMan : RichMan, SocialWorker
    {

        private String name;
        private String address;

        public void donation()
        {
            Console.WriteLine("Giving Donation");
        }

        public void earnMoney()
        {
            Console.WriteLine("Earing Money");
        }

        public void helpToOthers()
        {
            Console.WriteLine("Helping to Others");
        }

        public void party()
        {
            Console.WriteLine("Injoying Party");
        }
    }
}