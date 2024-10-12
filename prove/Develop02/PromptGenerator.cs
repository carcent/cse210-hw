public class Prompts
{
    public static List<string> _prompts = new List<string>
    {
    "Were you able to share your testimony?", "Is there something you would like to change that you did today?", "Did you meet anyone today?", "Did you find an opportunity to share the gospel?", "How was your interaction with others today?"
    };
    Random rnd = new Random();
    public string GetRandomPrompt()
    {
        int prompt = rnd.Next(_prompts.Count);     
        return _prompts[prompt];
    }    
} 