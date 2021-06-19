using System;

// Practicing with classes and constructors

public class Car
{
    private string vin;
    private string make;
    private string model;
    private int mileage;
    public Car()
    {
        vin = "";
        make = "";
        model = "";
        mileage = 0;
    }
    public Car(string v, string ma, string mo, int mi)
    {
        vin = v;
        make = ma;
        model = mo;
        mileage = mi;
    }
    public void Drive(int miles)
    {
        // increases mileage by the integer entered
        mileage = mileage + miles;
        return (mileage);
    }
    public void Display()
        // shows the vin, make, model, and mileage
    { Console.WriteLine($"VIN: {vin}, Make: {make}, Model: {model}, Mileage: {mileage}"); }
}

public class Program
{
    public static void Main(string[] args)
    {
        // I make two cars as examples
        Car[] cars = new Car[2];
        cars[0] = new Car("12ab3", "Honda", "Accord", 30000);
        cars[1] = new Car("45cd6", "Toyota", "Prius", 10000);
        // I increase the Accord's mileage by 10k, and the Prius' mileage by 20k
        cars[0].Drive(10000);
        cars[1].Drive(20000);
        // Final output should show the vin, make, model, and mileage
        // Accord final mileage should be 40k (30k+10k)
        // Prius final mileage should be 30k (10k+20k)
        cars[0].Display();
        cars[1].Display();
    }
}
