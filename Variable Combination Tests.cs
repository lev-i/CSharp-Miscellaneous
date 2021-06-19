using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Testing variable output types

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isIt = true;
            string s = "A string";
            int i = -1;
            char c = '&';

            var r1 = isIt + s;
            Console.WriteLine("Boolean + string results in concatenation and resulting type is " + r1.GetType());
            var r2 = s + s;
            Console.WriteLine("string + string results in concatenation and resulting type is " + r2.GetType());
            var r3 = s + i;
            Console.WriteLine("string + char results in concatenation and resulting type is " + r3.GetType());
            var r4 = s + i;
            Console.WriteLine("string + int results in concatenation and resulting type is " + r4.GetType());
            var r5 = i + c;
            Console.WriteLine("int + char results in addition(with ASCII of char) and resulting type is " + r5.GetType());
            var r6 = i + i;
            Console.WriteLine("int + int results in addition and resulting type is " + r6.GetType());
            var r7 = c + c;
            Console.WriteLine("char + char results in addition(with ASCII of char) and resulting type is " + r7.GetType());

        }

    }
}