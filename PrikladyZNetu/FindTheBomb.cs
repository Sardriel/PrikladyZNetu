using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class FindTheBomb
    {
        public string FindBomb(string sentence)
        {
            string bomb = "Duck!!!";
            string nobomb = "Relax, there is no bomb.";
            sentence = sentence.ToLower();
            if (sentence.Contains("bomb"))
            {
                return bomb;
            }
            else
            {
                return nobomb;
            }
        }


    }
}
