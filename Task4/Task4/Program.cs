using System;

namespace ShapeAreaCalculatorAndStatistics
{
    // Base class Shape with virtual method CalculateArea
    public abstract class Shape
    {
        public abstract double CalculateArea(params double[] dimensions);
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public override double CalculateArea(params double[] dimensions)
        {
            if (dimensions.Length < 2)
            {
                throw new ArgumentException("Rectangle requires at least two dimensions (width and height).");
            }

            double width = dimensions[0];
            double height = dimensions[1];
            return width * height;
        }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public override double CalculateArea(params double[] dimensions)
        {
            if (dimensions.Length != 1)
            {
                throw new ArgumentException("Circle requires exactly one dimension (radius).");
            }

            double radius = dimensions[0];
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    // Statistics class
    public class Statistics
    {
        public double GetAverage(params double[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("At least one value must be provided to calculate the average.");
            }

            double sum = 0;
            foreach (double value in values)
            {
                sum += value;
            }

            return sum / values.Length;
        }

        public void FindMinAndMax(double[] values, out double minValue, out double maxValue)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("At least one value must be provided to find the minimum and maximum.");
            }

            minValue = double.MaxValue;
            maxValue = double.MinValue;

            foreach (double value in values)
            {
                if (value < minValue)
                {
                    minValue = value;
                }

                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of derived shapes
            Shape rectangle = new Rectangle();
            Shape circle = new Circle();

            // Calculate areas
            double rectangleArea = rectangle.CalculateArea(5, 10); // width = 5, height = 10
            double circleArea = circle.CalculateArea(7); // radius = 7

            // Display areas
            Console.WriteLine($"Rectangle Area: {rectangleArea}");
            Console.WriteLine($"Circle Area: {circleArea}");

            // Create Statistics object
            Statistics stats = new Statistics();

            // Calculate average
            double average = stats.GetAverage(1, 2, 3, 4, 5);

            // Find min and max
            double[] numbers = { 1, 2, 3, 4, 5 };
            stats.FindMinAndMax(numbers, out double minValue, out double maxValue);

            // Display statistics
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Min Value: {minValue}");
            Console.WriteLine($"Max Value: {maxValue}");
        }
    }
}
