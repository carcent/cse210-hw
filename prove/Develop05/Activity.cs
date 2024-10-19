using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public void DisplayStartingMessage()
    {
        Console.Clear(); 
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session?");
        string response = Console.ReadLine();
        _duration = int.Parse(response);
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nActivity complete. Well done!");
    }
    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds ; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
    }
        
    public void ShowCountdown(int seconds)
    {
        for (int i = 5; i>0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }

    }
}