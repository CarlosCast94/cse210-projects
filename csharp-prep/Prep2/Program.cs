using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int RealGrade = int.Parse(grade);

        string letter = "";

        if (RealGrade >= 90)
        {
            letter = "A";
        }
        else if (RealGrade >= 80)
        {
            letter = "B";
        }
        else if (RealGrade>= 70)
        {
            letter = "C";
        }
        else if (RealGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
    }
}