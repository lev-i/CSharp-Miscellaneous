using System;

// Simple calculator for distance between two points with x, y, and z coordinates
namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = Distance2(1.0, 2.0, 3.0, 4.0, 5.0, 10.0);
            Console.WriteLine($"Distance is {dist}.");
        }
        public static double Distance2(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
        }
    }
}
