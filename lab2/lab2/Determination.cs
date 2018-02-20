using System;

namespace lab2
{
    class Determination
    {
        public int Redefinition(string primary)
        {
            int value=1; //If string is int
            if (!Int32.TryParse(primary, out int intnumber))
            {
                value = 2;//If string is double
             }
            if (!Double.TryParse(primary, out double doublenumber))
            {
                value = 0;//If string can not be a number
            }
            return value;
        }
    }
}
