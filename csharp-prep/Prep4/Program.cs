using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        List<float> positiveNumbers = new List<float>();
        List<float> negativeNumbers = new List<float>();
        float total = 0;
        float count = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        float number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string enteredNum = Console.ReadLine();
            number = float.Parse(enteredNum);
            if (number != 0)
            {
                numbers.Add(number);
                total += number;
                count += 1;
            }
        }
    
        foreach (float num in numbers)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
            else
            {
                negativeNumbers.Add(num);
            }
        }
        positiveNumbers.Sort();
        float largestNum = positiveNumbers[positiveNumbers.Count-1];
        float smallestNum = positiveNumbers[0];
        float average = total / count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine($"The sorted list:");
        negativeNumbers.Sort();
        foreach (float y in negativeNumbers)
        {
            Console.WriteLine(y);
        }
        foreach (float x in positiveNumbers)
        {
            Console.WriteLine(x);
        }
    }
}