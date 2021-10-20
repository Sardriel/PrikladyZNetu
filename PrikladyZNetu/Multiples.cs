using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class Multiples
    {

        public string CreateMultiple(int delkaPole, int nasobek)
        {
            string reseni = "";
            int[] pole = new int[delkaPole];
            int pomocna = nasobek;
            for (int i = 0; i < delkaPole; i++)
            {

                pole[i] = (nasobek);
                nasobek = nasobek + pomocna;
                
            }
            foreach (int i in pole)
                reseni += i +"\n";
            return reseni;
            

        }
        
    }
}
