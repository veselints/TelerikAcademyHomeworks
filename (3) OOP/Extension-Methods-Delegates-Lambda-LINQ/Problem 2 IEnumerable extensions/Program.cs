// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_IEnumerable_extensions
{
    public static class Test
    {
        static void Main(string[] args)
        {
            var testList = new List<double> {5.45, 4.3232, 5.7328, -293.4, 9};
            Console.WriteLine(testList.Sum());
            Console.WriteLine(testList.Poduct());
            Console.WriteLine(testList.Min());
            Console.WriteLine(testList.Max());
            Console.WriteLine(testList.Avarage());

        }

        public static T Sum<T>(this IEnumerable<T> collection) where T: struct
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            dynamic result = 0;
            foreach (var element in collection)
            {
                result += element;
            }
            return result;
        }

        public static T Poduct<T>(this IEnumerable<T> collection) where T : struct
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            dynamic result = 1;
            foreach (var element in collection)
            {
                result *= element;
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            dynamic maximumValue = long.MinValue;
            foreach (var element in collection)
            {
                if (element > maximumValue)
                {
                    maximumValue = element;
                }
            }
            return maximumValue;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            dynamic minimumValue = long.MaxValue;
            foreach (var element in collection)
            {
                if (element < minimumValue)
                {
                    minimumValue = element;
                }
            }
            return minimumValue;
        }

        public static T Avarage<T>(this IEnumerable<T> collection) where T : struct
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            dynamic result = 0;
            foreach (var element in collection)
            {
                result += element;
            }
            return result / collection.Count();
        }
    }
}
