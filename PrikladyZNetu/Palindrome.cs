using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class Palindrome
    {
        public void CheckPalindrome()
        {
            Console.WriteLine("Enter a word to verify:");
            string originalWord = Console.ReadLine().Trim();
            char[] charArray = originalWord.ToCharArray().Reverse().ToArray();
            string reversWord = new string(charArray);
            if (originalWord == reversWord)
            {
                Console.WriteLine("Word is palindrome");
            }
            else
            {
                Console.WriteLine("Word is not palindrome");
            }
        }
    }
}
