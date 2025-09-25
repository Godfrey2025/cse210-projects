using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Bake Bread", "Chef Emma", 420);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "I love the step-by-step guide."));
        video1.AddComment(new Comment("Charlie", "Can you do sourdough next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("DIY Home Office Setup", "TechGuy", 315);
        video2.AddComment(new Comment("Diana", "Great tips for small spaces."));
        video2.AddComment(new Comment("Ethan", "Loved the cable management ideas."));
        video2.AddComment(new Comment("Fiona", "Where did you get that desk?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Yoga for Beginners", "WellnessWithMaya", 600);
        video3.AddComment(new Comment("George", "Perfect for my morning routine."));
        video3.AddComment(new Comment("Hannah", "I feel so relaxed now."));
        video3.AddComment(new Comment("Ian", "Please make a follow-up video!"));
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

























}



