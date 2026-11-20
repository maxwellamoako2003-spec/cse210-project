using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Introduction to C#",
            "John Smith",
            600
        );

        video1.AddComment(new Comment("Mary", "Great explanation!"));
        video1.AddComment(new Comment("David", "This helped me understand C#."));
        video1.AddComment(new Comment("Peter", "Looking forward to more videos!"));

        // Create the second video
        Video video2 = new Video(
            "Learning HTML and CSS",
            "Sarah Johnson",
            850
        );

        video2.AddComment(new Comment("Michael", "Very informative."));
        video2.AddComment(new Comment("Grace", "I learned a lot."));
        video2.AddComment(new Comment("Daniel", "Thanks for sharing!"));
        video2.AddComment(new Comment("James", "Please make another tutorial."));

        // Create the third video
        Video video3 = new Video(
            "Understanding Python",
            "David Brown",
            720
        );

        video3.AddComment(new Comment("Alice", "Excellent lesson."));
        video3.AddComment(new Comment("Samuel", "Python is interesting."));
        video3.AddComment(new Comment("Esther", "This was easy to follow."));

        // Create the fourth video
        Video video4 = new Video(
            "Introduction to Web Development",
            "Mary Wilson",
            950
        );

        video4.AddComment(new Comment("Joseph", "Very helpful content."));
        video4.AddComment(new Comment("Linda", "I enjoyed this tutorial."));
        video4.AddComment(new Comment("Robert", "Keep up the good work!"));
        video4.AddComment(new Comment("Paul", "Looking forward to the next one."));

        // Store all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}"
                );
            }

            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}