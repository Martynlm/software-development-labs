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
        foreach (int i in array)
        {
        newArray.Add(i);
        }
        foreach(int i in array)
        {
            foreach(int j in array)
            {
                if(Math.Abs((i+j)-array.Max())<=1)
                {
                    newArray.Insert(i+1, array.Max());
                }
            }
        }
            foreach(int i in newArray)
             {
                Console.Write(i + " ");
             }
        }
    }
}   