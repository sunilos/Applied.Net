using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class TestInterface
    {
        public static void Test()
        {

            RichMan rm = new BusinessMan();
            SocialWorker sw = new BusinessMan();
            BusinessMan bm = new BusinessMan();

            rm.Party();
            rm.EarnMoney();
            rm.Donation();

            sw.HelpToOthers();

            bm.Party();
            bm.Donation();
            bm.EarnMoney();
            bm.HelpToOthers();
        }
    }
}