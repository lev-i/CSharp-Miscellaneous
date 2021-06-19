using System;

// Checks if there are any unpaired parentheses in the program
// Negative means there are that many )
// Positive means there are that many (
// 0 means all paired

namespace Parentheses Checker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CountSingleParenthesis("(Hello World)"));
            Console.WriteLine(CountSingleParenthesis("(Hello World"));
            Console.WriteLine(CountSingleParenthesis("Hello World)"));
        }
        public static int CountSingleParenthesis(string s)
        {
            int len = s.Length;
            int i = 0;
            int count = 0;
            while (i < len)
            {
                char c = s[i];
                if (c.Equals('('))
                {
                    count = count + 1;
                }
                else if (c.Equals(')'))
                {
                    count = count - 1;
                }
                i = i + 1;
            }
            return count;
        }
    }
}