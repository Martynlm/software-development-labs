using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<int>> Array = new List<List<int><23 3 21 3>;

            //int[][] newArray = new int[4][]
            //{
            // new int[] {1,3,5,7,9},
            // new int[] {0,2,4,6},
            // new int[] {11,22},
            // new int[4],
            //};
            //Array.Add(23);
            //newArray[3][0] = Array[0];
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.Write("Element({0}): ", i);

            //    for (int j = 0; j < newArray[i].Length; j++)
            //    {
            //        Console.Write(newArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            List<List<int>> list = new List<List<int>>(); //инициализация
            list.Add(new List<int>() { 3, 2, 1});//добавление новой строки
            list.Add(new List<int>() { 5, -6, 7});
            list.Add(new List<int>() { 3, 2, -3,});
            AddToAnArray newStroke = new AddToAnArray(list);
            //list.Add(newStroke.Add());
            foreach(int i in newStroke.Add())
            {
                Console.WriteLine(i + " ");
            }
            //for (int i = 0; i < list.Count+1; i++)
            //{
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        Console.WriteLine(list[i][j]+ " ");
            //    }
            //}
            Console.ReadLine();

        }
    }
}
