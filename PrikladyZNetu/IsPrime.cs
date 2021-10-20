using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class IsPrime
    {
        public string IsThatNumberPrime (int number)
        {
            string prime = "Number is Prime";
            string noPrime = "Number is not Prime";
            bool IsPrime = true;
            if (number == 1)
            {
                IsPrime = false;
            }
            else

            {
                for (int i = 2; i < number / 2; i++)
                {

                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }

                }
            }
            if (IsPrime)
            {
                return prime;
            }
            else
            {
                return noPrime;
            }

            
        }
    }
}
