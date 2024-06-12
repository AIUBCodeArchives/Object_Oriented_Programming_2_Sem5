using System;
public class Example
{
    public static void PrintNumbers(params int[] numbers)
    {
        Console.WriteLine("Params-");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void Increment(ref int number, ref int number1)
    {
        number++;
        number1++;
    }
    public static void GetValues(out int a, out int b)
    {
        a = 5;
        b = 10;
    }


    public static void Main()
    {
        //Params
        //PrintNumbers(1, 2, 3, 4, 5, 12, 34, 123);  // You can pass any number of arguments

        //ref
        int num = 5;
        int num1 = 6;
        Increment(ref num, ref num1);
        Console.WriteLine($"Ref- {num}, {num1}");  

        //out
        int x, y;
        GetValues(out x, out y);
        Console.WriteLine($"Out- x: {x}, y: {y}");  // Outputs: x: 5, y: 10
    }
}
