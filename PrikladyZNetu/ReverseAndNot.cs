using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class ReverseAndNot
    {
        public void DoReverseAndAddNotReverse()
        {
            int i = 123456789;
            string s = i.ToString();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray) + i);
        }
    }
}
