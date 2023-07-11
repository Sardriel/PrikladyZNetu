using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class PitoNDecimalPlaces
    {
        public string RoundPiToNDecimal(int number)
        {
            
            if (number > 15)
            {
                return ($"The number {number} is greater than 15");
            }
            else
            {
                double roundPi = Math.Round(Math.PI, number);
                return  ($"{roundPi}");
            }

            
        }

    }
}
