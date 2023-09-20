using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);
        int guesses = 0;
        bool correct = false;
        Console.WriteLine("Guess the number! It is between one and 20.");
        Console.WriteLine("You'll be told if your guess is higher or lower than the answer.");
        while (correct != true)
        {
            
            string guess = Console.ReadLine();
            
            if (int.Parse(guess) == number)
            {
                correct = true;
            }
            else
            {
                if (int.Parse(guess) < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            guesses ++;
        }
        Console.WriteLine("The answer you wrote was correct, good job.");
        Console.WriteLine($"It took you {guesses} attempts to get the correct answer.");
    }
}