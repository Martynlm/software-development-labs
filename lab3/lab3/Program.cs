//Дан целочисленный массив размера N. Вывести вначале все его четные элементы, а затем — нечетные.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty; //сюда мы сохраним введенную информацию 
            s = Console.ReadLine();//непосредственно считывание. 
            string[] st = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string array = Console.ReadLine();//объявление и считывание. 
            string[] st = array.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int size = st.Length;
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
            Count evenNumbers = new Count(mas);
            evenNumbers.Sorting();
            Console.ReadLine();
        }
    }
}
