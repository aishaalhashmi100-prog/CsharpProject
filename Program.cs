using System;

class Program
{
    // Task 2 Function
    static int Square(int number)
    {
        return number * number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Square(num);

        Console.WriteLine("Square = " + result);
    }
}