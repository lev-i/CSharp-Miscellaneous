using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

// Program to check if a word is Abecedarian
// Abecedarian - all the letters are in alphabetical order

namespace Abecedarian
{
    class Program
    {
        static void Main(string[] args)
        {
            // invoking the Abecedarian method
            Console.WriteLine(IsAbecedarian("acorsy"));
            Console.WriteLine(IsAbecedarian("Jim"));
            Console.WriteLine(IsAbecedarian("biopsy"));
        }
        static bool IsAbecedarian(string a)
        {
            // Set string to lower case

            string s = a.ToLower();

            if (s.Length > 2)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    // cheak ASCII code values compared to previous character
                    if (i <= (s.Length - 2) && !((int)s[i] <= (int)s[i + 1]))
                        return false;
                }
            }
            // in case string has exactly 2 character
            else if (s.Length == 2)
            {
                if ((int)s[1] < (int)s[0])
                    return false;
            }
            // catch all for 1 character strings
            else
            {
                return false;
            }
            // otherwise string is abecedarian
            return true;
        }

    }
}