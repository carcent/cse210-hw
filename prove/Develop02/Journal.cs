using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    


    public void AddEntry(Entry e1)
    {
        //string date = e1._date;
        //string question = e1._promptText;
        //string response = e1._entryText;
        //string entrada = date + " ~ " + question + "\n" + response;
        _entries.Add(e1);
      

                
    }

    public void DisplayAll()
    {
          foreach (var i in _entries)
        {
            Console.WriteLine("");
            i.DisplayEntry();
            Console.WriteLine("");
    //        Console.WriteLine("not sure what you are doing");
        }
       
        
       
    }

    public void SaveToFile(string filename)
    {
       
       //Console.Write("What is the file name that you want to load your Journal from?");
       //filename = Console.ReadLine();
       //check if file exist   
       if (!File.Exists(filename))
       {
        //creat file if it doesn't exist
        File.Create(filename).Close();
        Console.WriteLine("Filed created");
       }          
        using (StreamWriter outputFile = new StreamWriter(filename))
        { 
            foreach( var i in _entries)
            {
                outputFile.WriteLine($"{i._date} ~ {i._promptText} /n {i._entryText}");
            }
            
            Console.WriteLine("Saved");
        }
        
    }
    public void LoadFromfile(string filename)
       {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Loaded successfully!");
       }

}