using System;

class Program
{
    static void Main()
    {
        Console.Write("How many grades? ");
        int count = Convert.ToInt32(Console.ReadLine());

        double total = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Grade {i}: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            total += grade;
        }

        double average = total / count;

        Console.WriteLine($"Average: {average:F2}");

        if (average >= 3.0)
        {
            Console.WriteLine("The student passed.");
        }
        else
        {
            Console.WriteLine("The student failed.");
        }
    }
}