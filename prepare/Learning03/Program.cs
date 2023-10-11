using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(5,3);
        string fractionString = fraction.GetFractionString();
        double fractionFloat = fraction.GetDecimalValue();
        Console.WriteLine($"{fractionString}");
        Console.WriteLine($"{fractionFloat}");
    }
}