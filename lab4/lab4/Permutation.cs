using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    class Permutation
    {
        private int[] arr;
     public Permutation(int[] beginArray)
        {
            arr = beginArray;
        }

        private int[] MinMore(int positive, int negative)
        {
            int difference = negative- positive;
            List<int> newArray = new List<int>();
            for (int i = negative - 1; i > positive; i--)
            {
                newArray.Add(arr[i]);
            }
            Array.Reverse(newArray.ToArray());
            int j = newArray.Count - 1;
            for (int i = negative - 1; i > positive; i--)
            {
                arr[i] = newArray[j];
                j--;
            }
            return arr;
        }

        private int[] MaxMore(int positive, int negative)
        {
            int r = positive - negative;
            List<int> newArray = new List<int>();
            for (int i = positive - 1; i > negative; i--)
            {
                newArray.Add(arr[i]);
            }
            Array.Reverse(newArray.ToArray());
            int j = newArray.Count - 1;
            for (int i = positive - 1; i > negative; i--)
            {
                arr[i] = newArray[j];
                j--;
            }
            return arr;
        }

        public int[] Grouping()
        {
            int positive = Array.IndexOf(arr, arr.Max());
            int negative = Array.IndexOf(arr, arr.Min());
            if(positive-negative>0)
            {
                MaxMore(positive, negative);
            }
            else
            {
                MinMore(positive, negative);
            }
            return arr;
        }

    }
}
