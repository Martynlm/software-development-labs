using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
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
            newArray.Addition();
            Console.ReadLine();
        }
    }
}
