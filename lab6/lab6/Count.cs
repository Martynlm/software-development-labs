using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Count
    {
        private int[] array;
        private int sizeArray;
        public Count(int[] beginArray, int size)
        {
            array = beginArray;
            sizeArray = size;
        }
        public void Deleting()
        {
            for (int i = 1; i < sizeArray; i++)
            {
                if(array[i]%array[0]==0)
                {
                    for(int j = i; j<array.Length-1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    sizeArray--;
                }
            }
            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
