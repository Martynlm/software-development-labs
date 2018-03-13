using System.Collections.Generic;

namespace lab8
{
    class AddToAnArray
    {
        private List<List<int>> array;
        public AddToAnArray(List<List<int>> oldArray)
        {
            array = oldArray;
        }

        private int SumOfPositive(int i)
        {
            int sum = 0;
            for (int j = 0; j < array[i].Count; j++)
            {
                if (array[i][j] > 0)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        public List<int> Add()
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                int sum = SumOfPositive(i);
                for (int j = 0; j < array[i].Count; j++)
                {
                    if (array[i][j] < 0)
                    {
                        newArray.Add(sum);
                    }
                }
            }
            return newArray;
        }
    }
}
