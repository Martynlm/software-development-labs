using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0; //сюда мы сохраним итоговое число
            Console.WriteLine("Введите число: ");
            string s = Console.ReadLine();//объявление и считывание.
            number = Convert.ToInt32(s); //получение числа
            int i;
            int sum = 0, compos = 1;
            int[] arr = number.ToString().ToCharArray().Select(x => x - '0').ToArray();
            for (i = 0; i < 4; i++)
            {
                sum = sum + arr[i];
                compos = compos * arr[i];
            }
            Console.WriteLine("Число: {0}\nСумма = {1}\nУмножение = {2}", number, sum, compos);
            Console.ReadLine();
        }
    }
}
