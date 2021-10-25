using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class ReverseTheCase
    {
        public string ReversingTheCase(string originalSentence)
        {
            string solution = "";
            
            foreach (char character in originalSentence)
            {
                if (char.IsUpper(character)) 
                { 
                    solution += char.ToLower(character);
                    
                } 
                else 
                { 
                    solution += char.ToUpper(character);
                    
                }
            }
            return solution;
        }
        

    }
}
