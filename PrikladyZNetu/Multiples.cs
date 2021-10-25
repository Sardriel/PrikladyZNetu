using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class Multiples
    {

        public string CreateMultiple(int arrayLength, int multiple)
        {
            string solution = "";
            int[] array = new int[arrayLength];
            int pomocna = multiple;
            for (int i = 0; i < arrayLength; i++)
            {

                array[i] = (multiple);
                multiple = multiple + pomocna;
                
            }
            foreach (int i in array)
                solution += i +"\n";
            return solution;
            

        }
        
    }
}
