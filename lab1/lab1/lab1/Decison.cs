
using System.Linq;


namespace lab1
{

    class Decision
    {
        public int Sum(int number)
        {
            int[] numberDigits = NumberToDigits(number);
            return numberDigits.Sum();
        }
        public int Composition(int number)
        {
            int[] numberDigits = NumberToDigits(number);
            return numberDigits.Aggregate((result, current) => result * current);
        }

        private int[] NumberToDigits(int number)
        {
            int numberLegth = number.ToString().Length;
            int[] numberDigits = new int[numberLegth];
            for (int i = numberLegth - 1; i >= 0; i--)
            {
                numberDigits[i] = number % 10;
                number /= 10;
            }

            return numberDigits;
        }
    }
}
