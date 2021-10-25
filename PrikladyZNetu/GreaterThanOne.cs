using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class GreaterThanOne
    {
        public string CheckGreaterThanOne(string fraction)
        {
            string solution = "";
            string[] characters = fraction.Split("/");
            double numberOne = double.Parse(characters[0]);
            double numberTwo = double.Parse(characters[1]);
            double comparisonNumber = numberOne / numberTwo;
            bool checkTrue = true;

            if (comparisonNumber <= 1)
            {
                checkTrue = false;
            }
            solution += numberOne + "/" + numberTwo + " " + checkTrue;
            return solution;
        }
    }
}
