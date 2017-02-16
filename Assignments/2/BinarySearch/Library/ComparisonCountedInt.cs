using System;

namespace Library
{
    public class ComparisonCountedInt : IComparable
    {
        private int value;
        private int comparisonCount;

        public ComparisonCountedInt (int value)
        {
            this.value = value;
            this.comparisonCount = 0;
        }

        public int CompareTo(object other)
        {
            this.comparisonCount++;
            return this.value.CompareTo (other);
        }

        public int ComparisonCount 
        {
            get 
            {
                return this.comparisonCount;
            }
        }
    }
}

