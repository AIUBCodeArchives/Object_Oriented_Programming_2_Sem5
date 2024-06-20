using System;

public class Circle
{
    // Readonly field
    public readonly double Radius;
    public readonly double Area;

    // Constant field
    public const double Pi = 3.1415926535897931;

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
        Area = Pi * radius * radius;
    }

    // Method to display circle details
    public void Display()
    {
        Console.WriteLine($"Radius: {Radius}, Area: {Area}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        circle.Display();

        // Attempt to modify readonly field (uncommenting this line will cause a compilation error)
        // circle.Radius = 10.0;

        Console.WriteLine($"Pi: {Circle.Pi}");
        Console.ReadLine();
    }
}
