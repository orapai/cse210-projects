using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("We have upcoming events you might want to participate.\n");
        Console.WriteLine("------------------------------------------------------");
        Lectures lecture = new Lectures("Lectures", "Delivering Information", "A brief "+
        "lecture on how we can effectively deliver information", "Saturday, March 11", "9 "+
        "am", "123 Point street", "Chicago", "IL", "USA", "Adam Strong", 30);
        lecture.DisplayShortDescription();
        Receptions reception = new Receptions("Receptions", "Wedding Reception", "Wishing "+
        "the newlywed a long and happy life together.", "Tuesday, February 28", "5 pm", "123 "+
        "Patterson Road", "New York", "NY", "USA", "reservation@gmail.com");
        reception.DisplayShortDescription();
        OutdoorGatherings outdoor = new OutdoorGatherings("Outdoor Gathering", "After-Gathering "+
        "Concert", "Hear from our special speakers and enjoy the outdoor concert with free food "+
        "and drinks", "Saturday, March 4", "from 6-10 pm", "124 Pretty View Lane", "San Francisco"+
        "", "CA", "USA", "Mostly Clear");
        outdoor.DisplayShortDescription();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("\nFor full details, please see below:\n");

        lecture.DisplayLectureFullDetails();
        reception.DisplayReceptionFullDetails();
        outdoor.DisplayOutdoorGatheringFullDetails();

    }
}