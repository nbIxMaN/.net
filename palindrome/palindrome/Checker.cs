using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    public static class Checker
    {
        private static bool IsDelimiter(char x)
        {
            return Char.IsPunctuation(x) || Char.IsWhiteSpace(x);
        }
        public static bool CheckPolyndrome(string word)
        {
            var i = 0;
            var j = word.Length - 1;
            while (i <= j)
            {
                while (IsDelimiter(word[i]))
                    i++;
                //var symbol1 = Char.ToUpper(word[i]);
                while (IsDelimiter(word[j]))
                    j--;
                //var symbol2 = Char.ToUpper(word[j]);
                if ((i <= j) && (Char.ToUpper(word[i]) != Char.ToUpper(word[j])))
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}