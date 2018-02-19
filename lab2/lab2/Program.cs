using System;


namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string primarystring = Console.ReadLine();
            Determination calculator = new Determination();
            int resultValue = calculator.Redefinition(primarystring);
            Console.WriteLine(resultValue);
            Console.ReadLine();

        }
    }
}
