using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit64Array
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 arr = new BitArray64(7u);
            BitArray64 arr2 = new BitArray64(8u);

            Console.WriteLine(arr);
            arr[1] = 0;
            Console.WriteLine(arr);

            Console.WriteLine(arr[63]);

            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);
        }
    }
}
