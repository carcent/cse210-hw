
// STRETCH - Added to the GetRandomQuestion method a way to not repeat the same questions. 
using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
private List<string> _prompts;
private List<string> _questions;
private List<string> _askedQuestions;

 public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will prompt you to reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> { "Think about a time you overcame a challenge.", "Reflect on a moment of kindness.", "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "What did you learn?", "How did it make you feel?","Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        _askedQuestions = new List<string>();
    }
public void Run()
{
   
    DisplayStartingMessage();

    string prompt = GetRandomPrompt();
    Console.WriteLine($"Consider the following prompt: \n\n --{prompt}--\n");
    Console.WriteLine("When you have something in mind, press enter to continue");
    Console.ReadLine();   
    Console.Write("You may start in ");
    ShowCountdown(3);
    Console.Clear();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while(DateTime.Now < endTime)
    {
        string question = GetRandomQuestion();
        Console.Write($">{question}\n ");
        ShowSpinner(5);
        Console.WriteLine("");
    }
    
    DisplayEndingMessage();

}
private string GetRandomPrompt()
{
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
}
private string GetRandomQuestion()
{
    if(_askedQuestions.Count == _questions.Count)
    {
        _askedQuestions.Clear();
    }
    Random random = new Random();
    string question;
    do
    {
        question = _questions[random.Next(_questions.Count)];
    } while (_askedQuestions.Contains(question));
    return question;

}
private void DisplayPrompt()
{
    string prompt = GetRandomPrompt();
    Console.WriteLine($"Prompt:{prompt}");
}
private void DisplayQuestions()
{
    string question = GetRandomQuestion();
    Console.WriteLine($"Question: {question}");
}
}