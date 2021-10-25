using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikladyZNetu
{
    class AtmPinCodeValidation
    {
        public string AtmValidation(string pinCode)
        {
            bool validate = Int32.TryParse(pinCode, out int code);


            if (!validate)
            {
                return ($"There is a letter in code - Validate: {validate}");
            }
            else if ((pinCode.Length < 4) || (pinCode.Length > 5) || (pinCode.Length == 5))
            {
                validate = false;
                return ($"Code length is invalid - Validate: {validate}");
            }
            else
            {
                return ($"Your code is valid - Validate: {validate}");
            }
        }

    }
}
