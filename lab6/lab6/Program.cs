//Удалить элементы массива кратные его первому элементу(первыйэлемент при этом не рассматривать). Тестовый пример 2 3 4 5 -1 -2 -3-4. Результат: 2 3 5 -1 -3. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();//объявление и считывание. 
            string[] st = array.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            int size = st.Length;
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
            Count newArray = new Count(mas);
            foreach (int i in newArray.Deleting())
             Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
