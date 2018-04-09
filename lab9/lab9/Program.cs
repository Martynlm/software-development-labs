using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] beginArray = new int[3, 3] { { 1, 6, 2 }, { 4, 3, 5 }, { 9, 7, 8 } };
            Sorting newArray = new Sorting(beginArray);
            int[,] newMas = newArray.SortingNewArray();
            for (int i = 0; i <  newMas.GetLength(0); i++)
            {
                for (int j = 0; j < newMas.GetLength(1); j++)
                {
                    Console.Write(newMas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}