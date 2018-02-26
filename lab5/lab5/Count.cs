using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
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
        public void Addition()
        {
            //for (int i = 0; i < sizeArray+1; i++)
            //{
            //    for(int j=0; j<sizeArray; j++)
            //    {
            //        if (Math.Abs((array[i]+array[j])- array.Max()) <= 2)
            //        {
            //            for (int k=array.Length - 1; k>i+1; k--)
            //            {
            //                array[i] = array[i - 1];
            //            }
            //            array[i + 1] = array[i] + array[j];
            //            sizeArray++;
            //        }
            //    }
            //}


            for (int i = 0; i < sizeArray; i++)
            {

                if (array[i] > 100)
                {
                    for (int k = array.Length - 1; k > i + 1; k--)
                    {
                        array[k] = array[k - 1];
                    }
                    array[i + 1] = 10;
                    sizeArray++;
                }
            }



            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}