using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class ReversetheOddLengthWords
    {
        public void Reverse(string[] words)
        {
            
            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.Write("{0} ", word);
                }
                else if (word.Length % 2 != 0)
                {
                    char[] charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    Console.Write("{0} ", new string(charArray));
                }
            }
        }
    }
}
