using System;
using System.Globalization;

class Video
{
    public string _trackTitle;
    public string _trackAuthor;
    public string _trackLength;
    

    public List<Comment> comments = new List<Comment>();
    
    public void AddComment(string person, string text)
    {
        comments.Add(new Comment(person, text));
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoDetails()
    {
        string trackTitle = _trackTitle;
        string trackAuthor = _trackAuthor;
        string trackLength = _trackLength;
        int commentCount = GetCommentCount();
        Console.WriteLine("");
        Console.WriteLine($"Title: {trackTitle} ~ Author: {trackAuthor} ~ Length:{trackLength} sec  ~ It has {commentCount} comments");
        Console.WriteLine("");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment._person} says: {comment._comment}");
        }
    }

} 