//Дан массив размера 10. Переставить в обратном порядке элементы массива, расположенные между его минимальным и максимальным элементами.
using System;
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


        //private int[] IndexDifferenceMore(int o, int p)
        //    {
        //        int tempo = arr[p-1];
        //        for (int i=p-1; i<o; i--)
        //        {
        //            arr[i] = arr[o+1];
        //            arr[o+1] = tempo;
        //        }
        //        return arr;
        //    }
        public int[] Grouping()
        {
            int p = Array.IndexOf(arr, arr.Max());
            int o = Array.IndexOf(arr, arr.Min());
            //int tempo = arr[o];
            //arr[o] = arr[0];
            //arr[0] = tempo;
            //int tempp = arr[p];
            //arr[p] = arr[9];
            //arr[9] = tempp;
            int tempo = arr[p - 1];
                //IndexDifferenceMore(o,p);
                for (int i = p - 1; i > o; i--)
                {
                    arr[i] = arr[o + 1];
                    arr[o + 1] = tempo;
                }
            return arr;
        }

    }
}
