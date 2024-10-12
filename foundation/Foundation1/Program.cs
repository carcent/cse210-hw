using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video       
        {
            _tracktitle = "How to make a short",
            _trackauthor = "Jose Jones",
            _tracklength = "89"
           
        };
          Video video2 = new Video       
        {
            _tracktitle = "How to cook waffles",
            _trackauthor = "Mary Sawer",
            _tracklength = "185"
        };
          Video video3 = new Video       
        {
            _tracktitle = "Going home",
            _trackauthor = "Laury Shoes",
            _tracklength = "252"
        };
          Video video4 = new Video       
        {
            _tracktitle = "Living",
            _trackauthor = "Malena Rui",
            _tracklength = "160"
        };

        video1.AddComment("Susanita", "very informative");
        video1.AddComment("Mercedes", "can you expand on that?");
        video1.AddComment("henry", "thanks");
        video2.AddComment("Laura", "That was a great Recipe");
        video2.AddComment("lachic", "trying it today!");
        video2.AddComment("foodlover", "That recipe is the same that I use");
        video2.AddComment("marisa", "loving it");
        video2.AddComment("Samy", "That made me hungry");
        video3.AddComment("viajeros", "Love to go back home after a long trip");
        video3.AddComment("travelers", "tell us more about your experience there");
        video3.AddComment("missinghome", "I wish I could go back home");
        video4.AddComment("Casandra", "that is a great tip");
        video4.AddComment("laqueleetodo", "Like and subscribe to my channel");
        video4.AddComment("estomeestagustando", "que perdida de tiempo, como pude ver este video. ");
        video4.AddComment("livingloving", "That was Great! thanks for sharing");

        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();
        video3.DisplayVideoDetails();

    }


}