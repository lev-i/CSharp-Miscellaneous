using System;

// Multadd function to take three doubles and do (a*b+c)

namespace MultAdd
{
    class Program
    {
       
        public static double Multadd(double a, double b, double c)
        {
            // Adding multadd (a*b+c)
            return (double) (a * b + c);      
        }
        public static void Main(string[] args)
        {
            // Invoking multadd as 1*2+3
            double mA = Multadd(1.0, 2.0, 3.0);
            Console.WriteLine("1*2+3 is " + $"{mA}");
            // Calculating additional values with multadd
            double mA_trig = Multadd(Math.Cos(Math.PI / 4), 0.5, Math.Sin(Math.PI / 4));
            Console.WriteLine("Trigonometric function multadd is " + $"{mA_trig}");
            double mA_log = Multadd(Math.Log(10), (1 / Math.Log(10)), Math.Log(20) / Math.Log(10));
            Console.WriteLine("Logarithmic function multadd is " + $"{mA_log}");
        }

        // Writing method Yikes that invokes multadd
        public static void Yikes(double x)
        {
            Multadd(x, Math.Pow(Math.E,-x), Math.Sqrt(1-Math.Pow(Math.E,-x)));
        }
    }
}