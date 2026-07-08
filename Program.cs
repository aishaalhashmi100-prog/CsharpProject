using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total bill amount: ");
        double bill = double.Parse(Console.ReadLine()!);

        Console.Write("Are you a loyalty member (yes/no): ");
        string answer = Console.ReadLine()!;

        bool isMember = answer.ToLower() == "yes";

        double discount = 0;

        if (bill > 20 && isMember)
        {
            discount = bill * 0.15;
        }

        double finalAmount = bill - discount;

        Console.WriteLine("Original bill: " + bill + " OMR");
        Console.WriteLine("Discount: " + discount + " OMR");
        Console.WriteLine("Final amount: " + finalAmount + " OMR");
    }
}