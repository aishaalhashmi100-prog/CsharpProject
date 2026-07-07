using System;

class Program
{
    static void PrintWelcome(string name)
    {
        Console.WriteLine($"Welcome, {name}!");
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        PrintWelcome(name);
    }
}