using System;

public class Videos
{
    public List<Video> _videos = new List<Video>();
    Random numberCount = new Random();
    public Videos()
    {
    }
    private List<string> _names = new List<string>
    {
        "John David", "Harley", "John Doe", "Lee Smith",
        "Jack", "Ann Dee", "Whitney Sy", "Dave Mole", "Mee",
        "Andrew Deets", "Cassandra", "Joy Ashton", "Delight",
        "Dean Fan", "King", "Catastrophe", "Anonymous", "Johnny", 
        "Unknown", "Nope", "Kelly J.", "Merrari", "Karea", "Fin"
    };
    private List<string> _title = new List<string>
    {
        "Sunny Day", "Today's Tomorrow", "Finally Here!", "What Else Is There",
        "Tell Me It's Not Real", "Take Me Back To November", "No One Knows", 
        "From Here", "Take That Step", "The Wind's Whisper", "Delighted",
        "One Two Three", "Only You", "Tonight's Dinner", "Friendly", "Sweet Yet Bitter"
    };
    private List<string> _comments = new List<string>
    {
        "Incredibly amazing!", "Name of the actor please...", "love it!", "Clever!",
        "I cannot", "this is so awesome!", "can't wait for the next episode!!!", 
        "You killed the main character, already? not yet pleaaaase", "this is so funny", 
        "what was the mat for? lol", "hahhaha, not again!", "what was that?",
        "Hilarious", "You bet!", "Might gonna add this to my fave list", "I'm speechless",
        "adorable cat!", "I need one of those! haha", "isn't it gorgeous?", "I'd do the same!",
        "I'll buy it", "someone, please take me to this place, huhu", "I can die here"
    };
    public string GetComment()
    {
        int random = numberCount.Next(_comments.Count);
        return _comments[random];
    }
    public string GetName()
    {
        int random = numberCount.Next(_names.Count);
        return _names[random];
    }
    public string GetTitle()
    {
        int random = numberCount.Next(_title.Count);
        return _title[random];
    }
    public void displayAllVideos()
    {
        if (_videos.Count != 0)
        {
            Console.WriteLine("\n\n         All videos ");
            foreach(Video video in _videos)
            {
                video.displayVideo();
            }
        }
        else if (_videos.Count == 0)
        {
            Console.WriteLine("No videos added yet. ");
        }
    }
}