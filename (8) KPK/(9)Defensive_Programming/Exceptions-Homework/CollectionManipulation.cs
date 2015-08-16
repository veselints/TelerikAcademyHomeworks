namespace Exceptions_Homework
{
    using System.Collections.Generic;

    public class CollectionManipulation
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        

        
    }
}
