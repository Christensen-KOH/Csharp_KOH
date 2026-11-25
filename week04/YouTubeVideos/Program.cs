using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Present Simple Made Easy", "KOH-Speakers", 480);
        video1.AddComment(new Comment("Ivan", "thanks this finally makes sense"));
        video1.AddComment(new Comment("Anna", "Can you do past simple next?"));
        video1.AddComment(new Comment("Max", "watched this before my test, helped a lot"));
        videos.Add(video1);

        Video video2 = new Video("How to Speak English Without Translating", "KOH-Speakers", 720);
        video2.AddComment(new Comment("Elena", "I always translate in my head, going to try this"));
        video2.AddComment(new Comment("David", "good tips as always"));
        video2.AddComment(new Comment("Katya", "really liked the examples at 5:30"));
        video2.AddComment(new Comment("Tim", "subscribed!"));
        videos.Add(video2);

        Video video3 = new Video("C# Classes and Constructors for Beginners", "Chris Codes", 640);
        video3.AddComment(new Comment("Josh", "way clearer than the textbook lol"));
        video3.AddComment(new Comment("Paul", "thanks man, helped me finish my homework"));
        video3.AddComment(new Comment("Aaron", "do you have one about encapsulation?"));
        videos.Add(video3);

        Video video4 = new Video("5 Common English Mistakes to Fix Today", "KOH-Speakers", 515);
        video4.AddComment(new Comment("Olga", "number 3 got me every time"));
        video4.AddComment(new Comment("Denis", "short and useful, thanks"));
        video4.AddComment(new Comment("Maria", "please make part 2"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}