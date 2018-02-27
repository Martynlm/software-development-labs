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

 
        public int[] Grouping()
        {
            Array.Reverse(arr);
            int p = Array.IndexOf(arr, arr.Max());
            int tempp = arr[p];
            arr[p] = arr[9];
            arr[9] = tempp;
            int o = Array.IndexOf(arr, arr.Min());
            int tempo = arr[o];
            arr[o] = arr[0];
            arr[0] = tempo;
            return arr;
        }

    }
}
