// I used ChatGPT to help with some structure and basic guidance, but implementation and adjustments were made based on what I’ve learned during the course.


using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Videos
        Video video1 = new Video("Funny Cats Compilation", "CatLover123", 300);
        Video video2 = new Video("How to Bake a Cake", "BakingWithSarah", 600);
        Video video3 = new Video("Coding Tutorial", "TechGuru42", 1200);
        Video video4 = new Video("Travel Vlog: Japan", "WanderlustAdventures", 900);

        // Add Comments to Video 1
        video1.Comments.Add(new Comment("User1", "This is hilarious!"));
        video1.Comments.Add(new Comment("User2", "My cat does the same thing!"));
        video1.Comments.Add(new Comment("User3", "Love these compilations!"));
        video1.Comments.Add(new Comment("User4", "Where do you find these videos?"));

        // Add Comments to Video 2
        video2.Comments.Add(new Comment("BakingFan", "Great tutorial!"));
        video2.Comments.Add(new Comment("SweetTooth", "Can't wait to try this recipe!"));
        video2.Comments.Add(new Comment("CakeLover", "What kind of frosting did you use?"));

        // Add Comments to Video 3
        video3.Comments.Add(new Comment("Coder1", "Very helpful, thanks!"));
        video3.Comments.Add(new Comment("TechNoob", "I'm still confused, can you explain more?"));
        video3.Comments.Add(new Comment("DevMaster", "Nice and simple explanation."));

        // Add Comments to Video 4
        video4.Comments.Add(new Comment("Traveler", "Amazing video!"));
        video4.Comments.Add(new Comment("JapanLover", "I want to visit Japan now!"));
        video4.Comments.Add(new Comment("WorldExplorer", "Which cities did you visit?"));
        video4.Comments.Add(new Comment("Curious", "How expensive was the trip?"));

        // Add videos to the list.
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.Comments.Count}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); 
        }
    }
}