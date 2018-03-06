//Дан целочисленный массив размера N. Вывести вначале все его четные элементы, а затем — нечетные.


using System;

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
            int size = st.Length;
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
            Count Numbers = new Count(mas);
            Console.Write("Четные: ");
            foreach (int i in Numbers.SortingEven())
            {
                Console.Write(i + " ");
            }
            Console.Write("\nНечетные: ");
            foreach (int i in Numbers.SortingOdd())
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
