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
        public Count(int[] beginArray)
        {
            array = beginArray;
        }
        public List<int> Deleting()
        {
            List<int> newArray = new List<int>();
           foreach(int i in array)
            {
                    newArray.Add(i);
            }

            foreach (int i in newArray.ToArray())
            {
                if (newArray.IndexOf(i) == 0)
                    continue;
                if (i % newArray[0] == 0)
                {
                    newArray.Remove(i);
                }
            }
            return newArray;
        }
    
    }
}
