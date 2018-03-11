using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 1, 6, 2 }, { 4, 3, 5 }, { 9, 7, 8 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("------");
           Sorting newArray = new Sorting(array);
            int[,] SortingArray = newArray.SortingNewArray();
            for (int i = 0; i < SortingArray.GetLength(0); i++)
            {
                for (int j = 0; j < SortingArray.GetLength(1); j++)
                    Console.Write(SortingArray[i, j] + " ");
                    Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }

       
    }
}