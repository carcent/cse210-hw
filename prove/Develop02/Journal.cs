using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries;
    


    public void AddEntry(Entry newEntry)
    {
        string date = newEntry._date;
        string question = newEntry._promptText;
        string response = newEntry._entryText;
        string entrada = date + " ~ " + question + "\n" + response;

        foreach (var i in _entries)
        {
            
            Console.WriteLine(entrada);
        }

                
    }

    public void DisplayAll()
    {
        Console.WriteLine(_entries);
        Console.WriteLine("");
        Console.WriteLine("not sure what you are doing");
        Console.WriteLine(_entries);



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
            File.AppendText($"{"entrada"}");
            Console.WriteLine("Saved");
        }
        
    }
    public void LoadFromfile(string filename)
    {
        Console.WriteLine("What is the file name that you want to load your Journal from?");
                filename = Console.ReadLine();
                //if (filename in System.IO.File)

                string[] lines = System.IO.File.ReadAllLines(filename);
                Console.WriteLine($"Loading from {filename}");
    }

}