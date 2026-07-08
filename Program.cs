using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a whole number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }
    }
}