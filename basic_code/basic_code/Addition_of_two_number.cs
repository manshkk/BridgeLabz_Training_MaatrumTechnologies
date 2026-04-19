using System;

class Addition
{
    internal void SumOfTwoNumber()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int sum = a + b;

        Console.WriteLine("Result = " + sum);
    }
}