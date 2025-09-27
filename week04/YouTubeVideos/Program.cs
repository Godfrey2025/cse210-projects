using System;
using System.Collections.Generic;

// Main program
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Exploring the Amazon Rainforest", "NatureNow", 720);
        video1.AddComment(new Comment("Liam", "Amazing footage!"));
        video1.AddComment(new Comment("Sophia", "I learned so much."));
        video1.AddComment(new Comment("Noah", "Can you do one on the Sahara next?"));
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("DIY Home Office Setup", "TechSavvy", 480);
        video2.AddComment(new Comment("Emma", "Loved the cable management tips."));
        video2.AddComment(new Comment("Oliver", "Where did you get that desk?"));
        video2.AddComment(new Comment("Ava", "Super helpful for small spaces."));
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Beginner Yoga Routine", "ZenLife", 600    );
        video3.AddComment(new Comment("Mason", "Perfect for my morning routine."));
        video3.AddComment(new Comment("Isabella", "So calming and easy to follow."));
        video3.AddComment(new Comment("Lucas", "Please make a part 2!"));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
