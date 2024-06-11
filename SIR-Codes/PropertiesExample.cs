using System;

public class Person
{
    // Private field
    private string name;

    // Property with a backing field
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    // Auto-implemented property
    public int Age { get; set; }

    // Read-only property
    public string Gender { get; }

    // Constructor to initialize properties
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of Person
        Person person = new Person("John Doe", 30, "Male");

        // Accessing properties
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Gender: {person.Gender}");

        // Modifying properties
        person.Name = "Jane Doe";
        person.Age = 25;

        Console.WriteLine($"Modified Name: {person.Name}");
        Console.WriteLine($"Modified Age: {person.Age}");

        //Read-only property cannot be modified
        //person.Gender = "Female"; // This will cause a compilation error

    }
}
