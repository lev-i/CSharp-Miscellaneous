using System;

namespace Array_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // example array
            int[] a = { 3, 2, 5, 1, 4 };
            // temporary variable
            int tmp;
            // print original input array
            Console.WriteLine("The original array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            // sorting array characters
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            // printing sorted array
            Console.WriteLine("\nThe modified array :");
            foreach (int i in a)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
