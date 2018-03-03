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
            foreach (int i in newArray.ToArray())
            {
                foreach (int j in newArray.ToArray())
                {
                    if (i == newArray.Max())
                    {
                        continue;
                    }
                    if (newArray.IndexOf(i)==newArray.IndexOf(j))
                    {
                        continue;
                    }
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

        }
    }
}   