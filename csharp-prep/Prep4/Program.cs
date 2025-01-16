using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program collects numbers, calculates their sum, average, maximum, smallest positive number, and displays the sorted list.");
        Console.WriteLine("Like that one song said! Enter numbers one at a time. Type 0 to stop.");

        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Input: ");
            if (!int.TryParse(Console.ReadLine(), out int input) || input < 0)
            {
                Console.WriteLine("Please enter a valid non-negative number.");
                continue;
            }

            if (input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("Sorry but no numbers were entered. Heading to another planet.");
            return;
        }

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Sum of numbers: {sum}");

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"Average of numbers: {average:F2}");

        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"Maximum number: {max}");

        int? smallestPositive = null;
        foreach (var num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"Smallest positive number: {(smallestPositive.HasValue ? smallestPositive.ToString() : "None")}");

        numbers.Sort();
        Console.WriteLine("Sorted list:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
