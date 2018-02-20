using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class ArrayProcessing
    {
        //public int Count(int[] mas, int size)
        //{
           
        //    return ;
        //}

        public List<int> Even(int[] mas, int size)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if(mas[i]%2==0){
                    evenNumbers.Add(mas[i]);
                }
            }
            return evenNumbers;
        }

        //public int Uneven(int[] mas, int size)
        //{
        //    return;
        //}
    }
}
