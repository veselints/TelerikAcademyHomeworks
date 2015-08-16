using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM testGSM = new GSM("GXM-510", "Samsung", "Ivan", 540.50, new Battery("Rx_tgr", new TimeSpan(5, 06, 0, 0), BatteryType.Li_Ion), new Display(256));

            testGSM.AddCall(new Call(new DateTime(2014, 05, 03, 22, 45, 15), "+359 887 63 63 27", new TimeSpan(0, 00, 3, 13)));
            testGSM.AddCall(new Call(new DateTime(2014, 05, 04, 12, 35, 12), "+359 897 54 63 33", new TimeSpan(0, 00, 5, 23)));
            testGSM.AddCall(new Call(new DateTime(2014, 05, 04, 22, 36, 10), "+359 897 38 91 91", new TimeSpan(0, 00, 6, 22)));
            testGSM.AddCall(new Call(new DateTime(2014, 05, 05, 11, 01, 12), "+359 897 54 63 33", new TimeSpan(0, 00, 1, 13)));

            testGSM.DisplayCallsInfo();

            Console.WriteLine("The price for the calls is {0:C2}.", GSM.CalculateCallsPrice(testGSM));

            double longestCall = 0;
            int longestCallIndex = 0;

            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                if (testGSM.CallHistory[i].Duration.TotalSeconds > longestCall)
                {
                    longestCall = testGSM.CallHistory[i].Duration.TotalSeconds;
                    longestCallIndex = i;
                }
            }

            testGSM.DeleteCall(testGSM.CallHistory[longestCallIndex]);

            Console.WriteLine("The price for the calls is {0:C2}.", GSM.CalculateCallsPrice(testGSM));

            testGSM.ClearCallHistory();

            testGSM.DisplayCallsInfo();
        }
    }
}
