using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} ~ {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}

