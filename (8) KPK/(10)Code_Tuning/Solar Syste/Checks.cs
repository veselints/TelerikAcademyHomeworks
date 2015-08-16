using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SolarSystem
{
    class Checks
    {
        public static void Try()
        {
            // Measure time usage!
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                // Do something!
            }
            
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            // Measure memory usage!
            var memoryBefor = GC.GetTotalMemory(true);
            var currentList = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                currentList.Add(i);
            }
            var memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine(memoryAfter - memoryBefor);
            Console.WriteLine(currentList[2]);
        }
    }
}
