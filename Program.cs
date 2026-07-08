using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Do you have a valid national ID (yes/no): ");
        string answer = Console.ReadLine()!;

        bool hasID = answer.ToLower() == "yes";

        if (age >= 18 && hasID)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}