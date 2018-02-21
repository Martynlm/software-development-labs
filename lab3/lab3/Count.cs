using System;
using System.Collections.Generic;

namespace lab3
{
    class Count
    {
        private int[] array;
        public Count(int[] beginArray)
        {
           array = beginArray;
        }

        public void Sorting()
        {
            List<int> evenNumbers = new List<int>();
            List<int> unevenNumbers = new List<int>();
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    unevenNumbers.Add(i);
                }
            }
            Console.Write("Четные: ");
            foreach (int i in evenNumbers)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nНечетные: ");
            foreach (int i in unevenNumbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
