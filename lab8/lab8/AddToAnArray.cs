using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class AddToAnArray
    {
        private List<List<int>> array;
        public AddToAnArray(List<List<int>> oldArray)
        {
            array = oldArray;
        }

        private int SumOfEven(int i)
        {
            int sum = 0;
            for(int j=0; j<array.ToArray().GetLength(1); j++)
            {
                if(array[i][j]>0)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        public List<int> Add()
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < array.Capacity; i++)
            {
                for(int j=0; j<array.Capacity; j++)
                {
                    if(array[i][j]<0)
                    {
                        newArray.Add(SumOfEven(i));
                    }
                }
            }
            return newArray;
        }
    }
}
