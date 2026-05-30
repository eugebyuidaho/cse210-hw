using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Programming with C#","Eugenia Schulz", 560);
        video1.AddComment(new Comment("Alex", "Awesome video, thanks!"));
        video1.AddComment(new Comment("Julia","It helped me a lot, thank for your time."));
        video1.AddComment(new Comment("Gaston", "Now I understand better"));

        Video video2 = new Video("Encapsulation in C#","Jules Taylor", 430);
        video2.AddComment(new Comment("Mimmi", "I am ready for the next class, thank you!"));
        video2.AddComment(new Comment("Nicholas","This video saved me a lot of time"));
        video2.AddComment(new Comment("Henry", "Can you do a video about Abstraction too?"));

        Video video3 = new Video("Abstraction in C#","Erick Loverde", 610);
        video3.AddComment(new Comment("Joseph", "Your explanation was awesome!"));
        video3.AddComment(new Comment("Louis","Cool"));
        video3.AddComment(new Comment("Patricia", "I'm looking forward for your next video!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}