using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Permutation
    {
        private int[] arr;
     public Permutation(int[] beginArray)
        {
            arr = beginArray;
        }

        private int[] MinMore(int p, int o)
        {
            int r = o-p;
            List<int> newArray = new List<int>();
            for (int i = o - 1; i > p; i--)
            {
                newArray.Add(arr[i]);
            }
            Array.Reverse(newArray.ToArray());
            int j = newArray.Count - 1;
            for (int i = o - 1; i > p; i--)
            {
                arr[i] = newArray[j];
                j--;
            }
            return arr;
        }

        private int[] MaxMore(int p, int o)
        {
            int r = p - o;
            List<int> newArray = new List<int>();
            for (int i = p - 1; i > o; i--)
            {
                newArray.Add(arr[i]);
            }
            Array.Reverse(newArray.ToArray());
            int j = newArray.Count - 1;
            for (int i = p - 1; i > o; i--)
            {
                arr[i] = newArray[j];
                j--;
            }
            return arr;
        }

        public int[] Grouping()
        {
            int p = Array.IndexOf(arr, arr.Max());
            int o = Array.IndexOf(arr, arr.Min());
            if(p-o>0)
            {
                MaxMore(p, o);
            }
            else
            {
                MinMore(p, o);
            }
            return arr;
        }

    }
}
