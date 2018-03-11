using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Sorting
    {
        private int[,] array;
        public Sorting(int[,] beginArray)
        {
        array = beginArray;
        }

        private void Swap(int i, int j, int x, int y)
        {
            int temp = array[i, j];
            array[i, j] = array[x, y];
            array[x, y] = temp;
        }


        public int[,] SortingNewArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                        for (int y = 0; y < array.GetLength(1); y++)
                        {
                            if (array[i, j] > array[x, y])
                                Swap(i, j, x, y);
                        }
                    }
                }
            }
            return array;
        }

    }
}
