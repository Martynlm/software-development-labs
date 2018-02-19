using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Determination
    {
        public int Redefinition(string primary)
        {
            int value=1;
            if (!Int32.TryParse(primary, out int intnumber))
            {
                value = 2;
             }
            if (!Double.TryParse(primary, out double doublenumber))
            {
                value = 0;
            }
            return value;
        }
    }
}
