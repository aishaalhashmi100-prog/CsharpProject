using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine()!);

        double fahrenheit = (celsius * 9 / 5) + 32;

        string weather;

        if (celsius < 10)
        {
            weather = "Cold";
        }
        else if (celsius <= 30)
        {
            weather = "Mild";
        }
        else
        {
            weather = "Hot";
        }

        Console.WriteLine("Fahrenheit: " + fahrenheit);
        Console.WriteLine("Weather: " + weather);
    }
}