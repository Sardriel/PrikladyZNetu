using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class PositiveCountNegativeSum
    {
        public string CountPositiveSumNegative()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int countPositive = numbers.Count(positive => positive > 0);
            int sumNegative = numbers.Where(negative => negative < 0).Sum();
            if (numbers.Length == 0)
            {
                int[] emptyArray = { };
                return ($"{emptyArray}");
                
            }
            else
            {
                return ($"[{countPositive}, {sumNegative}]");
            }
            
        }
    }
}
