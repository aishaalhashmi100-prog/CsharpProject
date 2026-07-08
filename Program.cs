using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()!);

        string category;
        double price;

        if (age >= 0 && age <= 12)
        {
            category = "Children";
            price = 2.000;
        }
        else if (age >= 13 && age <= 59)
        {
            category = "Adults";
            price = 5.000;
        }
        else if (age >= 60)
        {
            category = "Seniors";
            price = 3.000;
        }
        else
        {
            category = "Invalid age";
            price = 0;
        }

        Console.WriteLine("Category: " + category);
        Console.WriteLine("Ticket price: " + price + " OMR");
    }
}
