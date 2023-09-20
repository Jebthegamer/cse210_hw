using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to C#!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int fav_number = int.Parse(Console.ReadLine());
        return fav_number;
    }
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Your name is {name} and the square of your favorite number is {number}.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int fav_number = PromptUserNumber();
        int numberSquared = SquareNumber(fav_number);
        DisplayResult(name, numberSquared);
    }
}