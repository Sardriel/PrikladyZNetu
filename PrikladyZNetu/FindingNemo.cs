using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class FindingNemo
    {
        public string FindNemo(string text)
        {
            
            string nemo = "Nemo";
            char[] separators = { '.', ',', '!', ':', ' ' };

            

            string[] wordsArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int indexOfNemo = Array.IndexOf(wordsArray, "Nemo") + 1;
            if (wordsArray.Contains(nemo))
            {
                
               
                return  ($"I found {nemo} at {indexOfNemo}!");
                
            }
            return ($"I can't find Nemo :(");
            
        }
    }
}
