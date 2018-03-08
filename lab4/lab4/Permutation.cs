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

<<<<<<< HEAD
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

=======

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
>>>>>>> 2a26356985b0b901862fa69522f9d492bc1ed3a3
        public int[] Grouping()
        {
            int p = Array.IndexOf(arr, arr.Max());
            int o = Array.IndexOf(arr, arr.Min());
<<<<<<< HEAD
            if(p-o>0)
            {
                MaxMore(p, o);
            }
            else
            {
                MinMore(p, o);
            }
=======
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
>>>>>>> 2a26356985b0b901862fa69522f9d492bc1ed3a3
            return arr;
        }

    }
}
