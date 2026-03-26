using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Intro to C#", "CodeMaster", 600);
        v1.AddComment(new Comment("Eric", "Very helpful!"));
        v1.AddComment(new Comment("Bryan", "Clear explanation."));
        v1.AddComment(new Comment("John", "Nice video!"));

        Video v2 = new Video("OOP Basics", "DevHub", 800);
        v2.AddComment(new Comment("Kofi", "Now I understand classes."));
        v2.AddComment(new Comment("Maxwell", "Great teaching!"));
        v2.AddComment(new Comment("Yaw", "Well explained."));

        Video v3 = new Video("Abstraction Explained", "TechWorld", 700);
        v3.AddComment(new Comment("Linda", "This helped a lot."));
        v3.AddComment(new Comment("Mark", "Simple and clear."));
        v3.AddComment(new Comment("Nana", "Good examples."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"- {comment.name}: {comment.text}");
            }

            Console.WriteLine();
        }
    }
}