//Дан целочисленный массив размера N. Вывести вначале все его четные элементы, а затем — нечетные.
<<<<<<< HEAD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System;
>>>>>>> 6e145de7758d83d71225b31378d3026fb952db72

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string s = string.Empty; //сюда мы сохраним введенную информацию 
            s = Console.ReadLine();//непосредственно считывание. 
            string[] st = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
=======
            string array = Console.ReadLine();//объявление и считывание. 
            string[] st = array.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
>>>>>>> 6e145de7758d83d71225b31378d3026fb952db72
            int size = st.Length;
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
<<<<<<< HEAD
            ArrayProcessing even = new ArrayProcessing();
            List<int> evenNumbers = even.Even(mas, size);
            Console.WriteLine(evenNumbers);
=======
            Count evenNumbers = new Count(mas);
            evenNumbers.Sorting();
>>>>>>> 6e145de7758d83d71225b31378d3026fb952db72
            Console.ReadLine();
        }
    }
}
