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
        public Count(int[] beginArray)
        {
            array = beginArray;
        }
        public void Addition()
        {
        List<int> newArray = new List<int>();
        List<int> forIndexs = new List<int>();
            foreach (int i in array)
        {
        newArray.Add(i);
        }
            foreach (int i in newArray)
            {
                foreach (int j in newArray)
                {
                    if (Math.Abs((i + j) - array.Max()) <= 1)
                    {
                        forIndexs.Add(newArray.IndexOf(i));
                    }
                }
            }

            foreach (int i in forIndexs)
            {
                Console.Write(i + " ");
            }


            //foreach(int i in forIndexs)
            //{
            //    newArray.Insert(i, array.Max());
            //}

            //foreach (int i in newArray)
            // {
            //    Console.Write(i + " ");
            // }
        }
    }
}   