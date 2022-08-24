using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class KonKEqualsN
    {

        public bool Equals(double n, double k)
        {
            double result = 1;
            for (int i = 0; i < k; i++)
            {
                result *= k;
            }

            return result == n;
        }

    }
}
