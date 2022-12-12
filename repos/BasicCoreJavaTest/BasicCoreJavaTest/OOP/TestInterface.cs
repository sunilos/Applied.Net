using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class TestInterface
    {
        public static void bussiness()
        {

            RichMan rm = new BusinessMan();
            SocialWorker sw = new BusinessMan();
            BusinessMan bm = new BusinessMan();

            rm.party();
            rm.earnMoney();
            rm.donation();

            sw.helpToOthers();

            bm.party();
            bm.donation();
            bm.earnMoney();
            bm.helpToOthers();
        }
    }
}
