using System;
using System.Globalization;

class Video
{
    public string _tracktitle;
    public string _trackauthor;
    public string _tracklength;
    

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
        string trackTitle = _tracktitle;
        string trackAuthor = _trackauthor;
        string trackLength = _tracklength;
        int commentCount = GetCommentCount();
        
        Console.WriteLine($"Title: {trackTitle} ~ Author: {trackAuthor} ~ Length:{trackLength} sec  ~ It has {commentCount} comments");
        Console.WriteLine("");
        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment._person} says {comment._comment}");
        }
    }

} 