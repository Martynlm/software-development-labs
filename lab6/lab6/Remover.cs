using System.Collections.Generic;
using System.Linq;

namespace lab6
{
    class Remover
    {
        private List<int> array;
        public Remover(int[] beginArray)
        {
            array = beginArray.ToList();
        }

        public List<int> Delete()
        {

            for (int i = 1; i < array.Count; i++)
            {
                if (i % array[0] == 0)
                {
                    array.Remove(i);
                    i--;
                }
            }
            return array;
        }

    }
}
