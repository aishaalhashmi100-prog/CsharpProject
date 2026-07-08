using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.Write("Enter operator (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine()!);

        double result;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                break;

            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}