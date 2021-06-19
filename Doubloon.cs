using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubloon
{
    // A word is said to be a "doubloon" if every letter that appears in the word appears exactly twice. This program will check if an input word is a doubloon.

    class Program
    {
        static void Main(string[] args)
        {
            // creating the IsDoubloon method
            IsDoubloon("Hannah");
            IsDoubloon("Jim");
            IsDoubloon("coco");
            IsDoubloon("emmett");
        }
        static void IsDoubloon(string a)
        {
            // Set the string to lowercase, capitalized letters are considered different from their lowercase counterparts, so if I didn't do this Hannah would  not be considered a doubloon, while hannah would be
            string x = a.ToLower();
            // I use a boolean that will ultimately state whether the string is a doubloon or not
            bool doubloon = true;
            // I use i and j to go through the string, letter by letter, and increment count for each time a letter appears
            for (int i = 0; i < x.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] == x[j]) count++;
                }
             // if count is any value besides two, the boolean is set to false, otherwise it remains true (as all letters appear exactly twice)
                if (count != 2)
                {
                    doubloon = false;
                    break;
                }
            }
            // Output the original string with judgement based on the boolean's final value
            if (doubloon == true)
            {
                Console.WriteLine($"{a} is a doubloon");
            }
            else
                Console.WriteLine($"{a} is not a doubloon");
        }
    }
}
