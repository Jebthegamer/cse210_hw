using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of numbers. Type 0 when completed.");
        List<int> numbers = new List<int>();
        int number = 1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int total = 0;
        int largest = -99999;
        foreach (int item in numbers)
        {
            total += item;
            if (item > largest)
            {
                largest = item;
            }
        }
        int average = total / numbers.Count();
        Console.WriteLine($"The total of the items was {total}.");
        Console.WriteLine($"The average of the numbers is {average}.");
        Console.WriteLine($"The largest item is {largest}.");
        Console.WriteLine($"The list organized is this:");
        numbers.Sort();
        foreach (int item in numbers)
        {
            Console.WriteLine($"{item}");
        }
    }
}