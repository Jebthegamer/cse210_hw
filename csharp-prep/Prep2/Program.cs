using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       /* Tell if the user passes or fails a class. The letter grades are as follows:
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
        Passing is >= 70
        >= 7 is +, <= 3 is -
       */
       // Ask the user for their grade, save the value
       Console.Write("What is your grade?: ");
       string gradeString = Console.ReadLine();
       int grade = int.Parse(gradeString);
       string letter = "";
       // Determine which letter corresponds to the grade
       if (grade >= 90)
       {
            letter = "A";
       }
       else if (grade >= 80)
       {
            letter = "B";
       }
       else if (grade >= 70)
       {
            letter = "C";
       }
       else if (grade >= 60)
       {
            letter = "D";
       }
       else
       {
            letter = "F";
       }
       // Calculate if the grade is + or - using modulus
       int remainder = grade % 10;
       string sign = "";
       if (remainder >= 7)
       {
            sign = "+";
       }
       else if (remainder <= 3)
       {
            sign = "-";
       }
       // If the grade is A or F, the grammar is slightly different. Also, there isn't a plus or minus.
       if (letter == "A" || letter == "F")
       {
            Console.WriteLine($"Your grade is an {letter}");
       }
       // ...however if the grade is B, C, or D there is a plus or minus, so include that in the logic.
       else
       {
            Console.WriteLine($"Your grade is a {letter}{sign}");
       }
       // Determine if the grade is in passing range, then print the associated message.
       if (grade >= 70)
       {
            Console.WriteLine("You passed the class, congratulations!");
       }
       else if (grade < 70)
       {
            Console.WriteLine("You failed the class, good luck next time.");
       }
    }
}