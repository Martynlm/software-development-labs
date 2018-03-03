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

        private int NumberOfPositive()
        {
            int value=0;
            foreach(int i in array)
            {
                if (i > 0)
                    value++;
            }
            return value;
        }

        private double Average()
        {
            int averageOfNumbers = 0;
            int sumOfPositiveNumbers = 0;
            foreach (int i in array)
            {
                if(i>0)
                {
                    sumOfPositiveNumbers += i;
                }
            }
            averageOfNumbers = sumOfPositiveNumbers / NumberOfPositive();
            return averageOfNumbers;
        }



        public List<int> Addition()
        {
        List<int> newArray = new List<int>();
            foreach (int i in array)
            {
               newArray.Add(i);
               if(Math.Abs(i) > Average())
                {
                    newArray.Insert(newArray.IndexOf(i) + 1, 0);
                }
            }
        return newArray;
        }
       
    }
}   