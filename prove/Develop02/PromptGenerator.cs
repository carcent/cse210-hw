public class Prompts
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
               
        
        Random rnd = new Random();
        int prompt = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[prompt]);
        return "";

    }    
}