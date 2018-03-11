using System.Collections.Generic;

namespace lab10
{
    class Remover
    {
        private List<int> array;
        public Remover(List<int> beginArray)
        {
            array = beginArray;
        }

        public List<int> Delete()
        {
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] % array[0] == 0)
                {
                    array.Remove(array[i]);
                }
            }
            return array;
        }

    }
}