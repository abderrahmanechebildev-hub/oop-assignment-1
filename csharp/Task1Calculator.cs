using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return;
            }

            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return;
        }

        Console.WriteLine($"Result: {result}");
    }
}