using System;
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

        public void Donation()
        {
            Console.WriteLine("Giving Donation");
        }

        public void EarnMoney()
        {
            Console.WriteLine("Earing Money");
        }

        public void HelpToOthers()
        {
            Console.WriteLine("Helping to Others");
        }

        public void Party()
        {
            Console.WriteLine("Injoying Party");
        }
    }
}