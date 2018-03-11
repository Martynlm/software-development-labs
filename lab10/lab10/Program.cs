using System;
using System.Collections.Generic;
using System.IO;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        { 
            string line;
            StreamReader sr = new StreamReader("input.txt");
            List<int> mas = new List<int>();
            while ((line = sr.ReadLine()) != null)
            {
                mas.Add(Convert.ToInt32(line));
            }
            foreach (int i in mas)
            {
                Console.WriteLine(i + " ");
            }
            Remover newArray = new Remover(mas);
            StreamWriter sw = new StreamWriter("output.txt");
            foreach (int i in newArray.Delete())
            {
                sw.Write(i + " ");
            }
            sw.Close();
            Console.ReadLine();
        }
    }
}
