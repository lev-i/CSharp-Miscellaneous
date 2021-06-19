using System;
using System.Collections.Generic;
using System.Linq;
using System;

// Fermat Theorem Checker

namespace Fermat
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Values of a, b, c, and n are input here
            CheckFermat(1, 2, 3, 1);
        }
        // Mapping out Fermat's Theorem
        public static void CheckFermat(int a, int b, int c, int n)
        {
            // saying if a^n+b^n=c^n is true, AND n >2, then Fermat was wrong
            if (Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n) && n > 2)
            {
                Console.WriteLine("Holy smokes, Fermat was wrong!");
            }

            // if those conditions can't be satisfied, Fermat was right
            else
            {
                Console.WriteLine("No, that doesn’t work.");
            }
        }
    }
}