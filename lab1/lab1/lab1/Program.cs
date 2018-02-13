using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string numberAsString = Console.ReadLine();
            int number = Convert.ToInt32(numberAsString);
            Decision calculator = new Decision();
            int resultSum = calculator.Sum(number);
            int resultComposition = calculator.Composition(number);
            Console.WriteLine("Число: {0}\nСумма = {1}\nУмножение = {2}", number, resultSum, resultComposition);
            Console.ReadLine();
        }
    }
}