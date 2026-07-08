using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter grade (A, B, C, D, F): ");
        char grade = Console.ReadKey().KeyChar;
        grade = char.ToUpper(grade);
        Console.WriteLine();

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;

            case 'B':
                Console.WriteLine("Very Good");
                break;

            case 'C':
                Console.WriteLine("Good");
                break;

            case 'D':
                Console.WriteLine("Pass");
                break;

            case 'F':
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("Invalid grade");
                break;
        }
    }
}