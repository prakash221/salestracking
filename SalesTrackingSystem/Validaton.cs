using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalesTrackingSystem
{
    public class Validaton
    {
        public bool stringValidatior(string input)//valading the text
        {
            string pattern = "[^A-Z a-z ^0-9 . @ _ -]";//Regex = regular expression  //search for an string pattern
            if (Regex.IsMatch(input, pattern))//comparing input and pattern
                return true;
            else
                return false;
        }

        public bool IntegerValidatior(string input)// valading the string
        {
            string pattern = "[^0-9]";//Regex = regular expression  //search for an string pattern
            if (Regex.IsMatch(input, pattern))//comparing input and pattern
                return true;
            else
                return false;
        }

        public bool IsEmpty(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
