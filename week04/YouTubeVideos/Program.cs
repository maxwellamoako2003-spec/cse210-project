using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video("Learning C#", "John Smith", 600);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("David", "This helped me understand C#."));
        video1.AddComment(new Comment("Mary", "Thanks for sharing!"));

        // Create the second video
        Video video2 = new Video("Introduction to HTML", "Sarah Johnson", 450);

        video2.AddComment(new Comment("Peter", "Very useful tutorial."));
        video2.AddComment(new Comment("Grace", "I learned something new."));
        video2.AddComment(new Comment("James", "Please make more videos."));

        // Create the third video
        Video video3 = new Video("CSS for Beginners", "Michael Brown", 720);

        video3.AddComment(new Comment("Emma", "Excellent lesson."));
        video3.AddComment(new Comment("Daniel", "The examples were helpful."));
        video3.AddComment(new Comment("Sophia", "I enjoyed this video."));

        // Store videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetComment());
            }

            Console.WriteLine();
        }
    }
}