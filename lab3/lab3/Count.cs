using System;
using System.Collections.Generic;

namespace lab3
{
    class Count
    {
        private int[] array;
        public Count(int[] beginArray)
        {
            array = beginArray;
        }

        public List<int> SortingEven()
        {
            List<int> evenNumbers = new List<int>();
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }
            return evenNumbers;
        }

        public List<int> SortingUneven()
        {
            List<int> unevenNumbers = new List<int>();
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    unevenNumbers.Add(i);
                }
            }
            return unevenNumbers;
        }


    }
}
