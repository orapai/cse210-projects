using System;
using System.IO;

class Program
{
    static void Main(string[] args)  
    {
        Journal entries = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            string getChoice = Console.ReadLine();
            choice = int.Parse(getChoice);

            switch(choice)
            {
                case 1:
                    Entry prompt = new Entry();
                    Prompt promptList = new Prompt();
                    prompt._prompt = promptList.GetPrompt();
                    Console.WriteLine(prompt._prompt);
                    prompt._entry = Console.ReadLine();
                    prompt._date = prompt.GetDate();
                    entries._journal.Add(prompt);
                    break;
                case 2:
                    entries.Display();
                    break;
                case 3:
                    Console.WriteLine("What is the filename? ");
                    string filenameRead = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filenameRead);
                    int maxLines = lines.Count();
                    entries = new Journal();
                    prompt = new Entry();
                    for(int i = 0; i < maxLines; i++)
                    {
                        if(i % 2 == 0)
                        {
                            prompt = new Entry();
                            string[] datePrompt = lines[i].Split(" ");
                            string date = datePrompt[1] + " " + datePrompt[2] + " " + datePrompt[3];
                            prompt._date = date;
                            datePrompt = lines[i].Split("-");
                            prompt._prompt = datePrompt[1];

                        }
                        else
                        {
                            prompt._entry = lines[i];
                            entries._journal.Add(prompt);
                        }
                    }

                    break;
                case 4:
                    Console.WriteLine("What is the filename? ");
                    string filename = Console.ReadLine();
                    System.IO.File.WriteAllLines($@"{filename}", entries.SaveEntries());
                    break;
            }
        }
    }
}