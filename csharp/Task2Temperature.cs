using System;

class Program
{
    static void Main()
    {
        Console.Write("Convert from Celsius (C) or Fahrenheit (F)? ");
        string choice = Console.ReadLine();

        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (choice.ToUpper() == "C")
        {
            double result = temperature * 1.8 + 32;
            Console.WriteLine($"{temperature}°C = {result:F2}°F");
        }
        else if (choice.ToUpper() == "F")
        {
            double result = (temperature - 32) / 1.8;
            Console.WriteLine($"{temperature}°F = {result:F2}°C");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}