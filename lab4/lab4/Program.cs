//Дан массив размера 10. Переставить в обратном порядке элементы массива, расположенные между его минимальным и максимальным элементами.
using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();//объявление и считывание. 
            string[] st = array.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
            Permutation arrayNumbers = new Permutation(mas);
            foreach (int i in arrayNumbers.Grouping())
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
