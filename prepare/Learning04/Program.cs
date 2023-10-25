using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Frederick Mulls", "Horticulture");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("17.4", "25, 36-40", "Terence McGee", "Fractions");
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Unfortunate Occurrence that Did Happen", "Snicket Lemony", "Freewriting");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}