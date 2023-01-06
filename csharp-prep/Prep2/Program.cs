using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letterGrade = "";
        string sign = "";
        string signTemp = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else if (percentage < 60)
        {
            letterGrade = "F";
        }

        if (percentage % 10 >= 3)
        {
            signTemp = "+";
        }
        else
        {
            signTemp = "-";
        }
        if (percentage >= 93 || percentage <= 59)
        {
            sign = "";
        }
        else if (percentage % 10 == 3 || percentage % 10 == 4 || percentage % 10 == 5 || percentage % 10 == 6)
        {
            sign = "";
        }
        else
        {
            sign = signTemp;
        }

        Console.WriteLine($"Grade: {letterGrade}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Don't give up, you can do it next time!");
        }
    }
}