using System;
// Mostly more practice with creating classes and objects
namespace RectangleArea
{
    public class Rect
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public static double ComputeArea1(Rect rec)
        {
            return rec.Height * rec.Length;
        }
        public double ComputeArea2()
        {
            return Height * Length;
        }
    }
    public class Program
    {
        public static void Main()
        {
            // Creating a new Rect object call r using the default constructor
            Rect r = new Rect { Height = 1, Length = 4 };
            Console.WriteLine("Original height is " + r.Height);
            Console.WriteLine("Original length is " + r.Length);

            // Invoking ComputeArea1 and display the area of r
            Console.WriteLine("Area is " + Rect.ComputeArea1(r));

            // setting both r's Height and Length to 3;
            r.Height = 3;
            r.Length = 3;
            Console.WriteLine("Updated height is " + r.Height);
            Console.WriteLine("Updated length is " + r.Length);

            // Invoking ComputeArea2 to display the area of r
            Console.WriteLine("New area is " + r.ComputeArea2());
        }
    }
}
