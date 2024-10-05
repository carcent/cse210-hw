using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    Reference _reference;
    private List<Word> _words; 
    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split())
        {
            _words.Add(new Word(word)); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {

        Random rnd = new Random();
        int count = 0;

        while (count < numberToHide && _words.Count >0)
        {
            int index = rnd.Next(_words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
    
}