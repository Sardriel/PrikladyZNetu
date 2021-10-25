using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class FindTheCharactersCounterpartCharCode
    {
        public string FindTheCounterPart(char character)
        {
            int helpChar;

            if (char.IsLower(character))
            {
                helpChar = char.ToUpper(character);
                return ($"Original Character: {character}, INT value of counterpart Char: " + helpChar);
            }
            else if (char.IsUpper(character))
            {
                helpChar = char.ToLower(character);
                return ($"Original Character: {character}, INT value of counterpart Char: " + helpChar);
            }
            else
            {
                helpChar = character;
                return ($"This character -{character}- doesn´t have counterpart, INT value of this character is: {helpChar}");
            }

            
        }

    }
}
