using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class ReturnTheHighestAndLowestNumbers
    {
        public string ReturnHighLow(string[] numberInput)
        {
            
            int[] numbers = new int[numberInput.Length];
            for (int i = 0; i < numberInput.Length; i++)
            {
                numbers[i] = int.Parse(numberInput[i]);
            }

            int high = numbers.Max();
            int min = numbers.Min();
            return ($"{high} {min}");

        }
    }
}
