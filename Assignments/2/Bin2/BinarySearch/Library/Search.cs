using System;
using System.Numerics;

namespace Library
{
    public static class Search
    {
        public static int Binary (IComparable[] array, IComparable target)
        {
            long low = 0;
            long high = array.Length - 1;
            int counter = 0;

            if (Array.BinarySearch(array, target) >= 0)
            {
                while (low <= high) 
                {
                    int mid = (int)(((high + low) / 2));
                    IComparable midVal = array [mid];
                    int relation = midVal.CompareTo (target);

                    counter = counter + 1;

                    if (relation < 0) {
                        low = mid + 1;
                    } else if (relation > 0) {
                        high = mid - 1;
                    } else {
                        return counter;
                    }
                }
            }
            return counter;
        }

        /// <summary>
        /// In constructing the Linear search for use within a test method to compare with binary search, it's helpful to declare a counter for each evaluation conducted. 
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="target">Target.</param>
        public static int Linear (IComparable[] array, IComparable target)
        {
            long len = array.Length;
            int counter = 0;

            for (int i = 0; i < len; i++)
            {
                counter++;
                if (array [i] == target)
                    return i;
            }
            return counter;
        }
    }
}