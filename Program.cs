static int Square(int number)
{
    return number * number;
}

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int result = Square(num);

Console.WriteLine($"Square of {num} is {result}");