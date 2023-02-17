using System;

class Program
{
    static void Main(string[] args)
    {
        Videos videos = new Videos();

        Random numberOfCount = new Random();
        int videoCount = numberOfCount.Next(3,5);
        Console.WriteLine($"Add {videoCount} videos:");
        switch(videoCount)
        {
            case 3:
                videoCount = 3;
                while(videoCount != 0)
                {
                    Video video = new Video();
                    video._author = videos.GetName();
                    video._title = videos.GetTitle();
                    video._lengthInSeconds = numberOfCount.Next(30,45);
                    int commentCount = numberOfCount.Next(3,5);
                    switch(commentCount)
                    {
                        case 3:
                            commentCount = 3;
                            while (commentCount != 0)
                            {
                                Comment comment = new Comment();
                                comment._personName = videos.GetName();
                                comment._textComment = videos.GetComment();
                                video._comment.Add(comment);
                                commentCount--;
                            }
                        break;
                        case 4:
                            commentCount = 4;
                            while (commentCount != 0)
                            {
                                Comment comment = new Comment();
                                comment._personName = videos.GetName();
                                comment._textComment = videos.GetComment();
                                video._comment.Add(comment);
                                commentCount--;
                            }
                        break;
                    }
                    videos._videos.Add(video);
                    videoCount--;
                }
            break;
            case 4:
                videoCount = 4;
                while(videoCount != 0)
                {
                    Video video = new Video();
                    video._author = videos.GetName();
                    video._title = videos.GetTitle();
                    video._lengthInSeconds = numberOfCount.Next(30,45);
                    int commentCount = numberOfCount.Next(3,5);
                    switch(commentCount)
                    {
                        case 3:
                            commentCount = 3;
                            while (commentCount != 0)
                            {
                                Comment comment = new Comment();
                                comment._personName = videos.GetName();
                                comment._textComment = videos.GetComment();
                                video._comment.Add(comment);
                                commentCount--;
                            }
                            break;
                        case 4:
                            commentCount = 4;
                            while (commentCount != 0)
                            {
                                Comment comment = new Comment();
                                comment._personName = videos.GetName();
                                comment._textComment = videos.GetComment();
                                video._comment.Add(comment);
                                commentCount--;
                            }
                        break;
                    }
                    videos._videos.Add(video);
                    videoCount--;
                }
                break;
        }
        videos.displayAllVideos();
    }
}

