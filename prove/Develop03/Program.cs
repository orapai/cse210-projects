using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5");
        Text text = new Text(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall bdirect thy paths.");
        Scripture scripture = new Scripture(text);
        string answer = "";
        bool start = true;
         
        do
        {
            if(!start)
            {
                scripture.hide();
            }
            else
            {
                start = false;
            }
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", reference.toString(), scripture.toString()));
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            Console.WriteLine();
            Console.ReadLine();
        }
        while(answer!="quit" && scripture.hasWordsLeft() ==  true);
    }
}