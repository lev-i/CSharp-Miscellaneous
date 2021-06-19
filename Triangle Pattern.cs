using System;

namespace Pattern
{
    class Program
    {
        // Creates a triangle of numbers with the number of digits on the line equaling the value of the digit itself

        static void Main(string[] args)
        {
            Pyramid(5);
        }
        public static void Pyramid(int m)
        {
            int j = 1;
            while (j <= m)
            {
                int i = 1;
                while (i <= j)
                {
                    Console.Write(j  + " ");
                    i++;
                }
                j++;
                Console.WriteLine();
            }
        }
    }
}
