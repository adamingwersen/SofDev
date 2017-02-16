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

            if (Array.BinarySearch(array, target) >= 0){
                while (low <= high) {
                    int mid = (int)(((high + low) / 2));
                    IComparable midVal = array [mid];
                    int relation = midVal.CompareTo (target);

                    if (relation < 0) {
                        low = mid + 1;
                    } else if (relation > 0) {
                        high = mid - 1;
                    } else {
                        return mid;
                    }
                }
            }

            return -1;
        }
    }
}