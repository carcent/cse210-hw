using System;
using System.Net;

class WalkingActivity: Activity
{
    public WalkingActivity()
    {
    _name = "walking Activity";
    _description = "This activity will help you relax the mind while also stretching and moving the body. As you walk, pay attention to the sensation of your feet touching the ground, the movement of your body, and the rhythm of your breath. Walking meditation can be done anywhere, from a park to your living room.";
    
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear(); 
        Console.WriteLine("Begin by standing still, feeling your feet on the ground. Take a few deep breaths to center yourself.");
        ShowSpinner(5);
        Console.Clear();
        Console.Write("Start walking at a slow, deliberate pace...");
        ShowCountdown(15);
        while (DateTime.Now< endTime)
        {
            Console.Write("\n\nPay attention to your breath...");
            ShowCountdown(4);

            Console.Write("inhale for a few steps...");
            ShowCountdown(5);

            Console.Write("exhale for a few steps...");
            ShowCountdown(5);  

            Console.Write("\n\nPay attention to the sensations in your body...");
            ShowCountdown(4);

            Console.Write("observe your surroundings....");
            ShowCountdown(5);

            Console.Write("\n\nKeep your focus...");
            ShowCountdown(5);  
            Console.Write("\n\nStep by step...\n");
            ShowCountdown(5);  
        }
        Console.WriteLine("");
        DisplayEndingMessage();
         ShowSpinner(3);
         Console.WriteLine($"\nYou have completed another {_duration} seconds of walking\n");
    }
}