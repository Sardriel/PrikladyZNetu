using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class ReverseTheCase
    {
        public string ReversingTheCase(string vetaOriginal)
        {
            string reseni = "";
            
            
            foreach (char z in vetaOriginal)
            {
                if (char.IsUpper(z)) 
                { 
                    reseni += char.ToLower(z);
                    
                } 
                else 
                { 
                    reseni += char.ToUpper(z);
                    
                }
                
                
                
                
            }
            return reseni;
        }
        

    }
}
