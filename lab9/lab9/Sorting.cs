using System;

namespace lab9
{
    class Sorting
    {
        private int[,] array;
        private int[] newArray = new int[9];
        public Sorting(int[,] beginArray)
        {
        array = beginArray;
        }

        private int[] FormatinArray()
        {
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[k] = array[i, j];
                    k++;
                }
            }
            Array.Sort(newArray);
            return newArray;
        }


        public int[,] SortingNewArray()
        {
            FormatinArray();
            int z = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = newArray[z];
                    z++;
                }
            }
            return array;
        }

    }
}
