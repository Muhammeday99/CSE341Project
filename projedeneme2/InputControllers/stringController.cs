using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projedeneme2.InputControllers
{
    public class stringController
    {
        static public bool listStringController(List<string> list){

            foreach(var stringPiece in list)
            {
                if (!singleStringController(stringPiece)) return false;
            }
            return true;
        }

        static public bool singleStringController(string input)
        {
            if (input.Length < 1) return false;
            return true;
        }

        static public int passwordSecurity(string input)
        {
            int securityLevel = 0;

            if (input.Any(char.IsDigit)) securityLevel++;

            if (input.Any(char.IsLetter))
            {
                if (input.Any(char.IsLower)) securityLevel++;
                if (input.Any(char.IsUpper)) securityLevel++;
            }

            if (input.Any(char.IsSymbol)) securityLevel++;

            return securityLevel;
        }
    }
}