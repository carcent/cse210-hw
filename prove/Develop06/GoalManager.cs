using System;

public class GoalManager
{
    private List <Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void CreateGoal()
    {
        Console.Write("Enter the type of goal (simple, eternal, checklist): ");
        string type = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (type.Equals("simple", StringComparison.OrdinalIgnoreCase))
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type.Equals("eternal", StringComparison.OrdinalIgnoreCase))
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type.Equals("checklist", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("Enter the target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(name, description, points, target));
        }
        else if (type.Equals("negative", StringComparison.OrdinalIgnoreCase))
        {
            _goals.Add(new NegativeGoal(name, description,points));
        }
        
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete? (Enter the number)");
        ListGoals();
        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= _goals.Count)
        {
            _goals[choice - 1].RecordEvent();
            _score += _goals[choice - 1].GetPoints();
            Console.WriteLine($"Event recorded! You gained {(_goals[choice - 1].GetPoints() >= 0 ? _goals[choice - 1].GetPoints() : -_goals[choice - 1].GetPoints())} points.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void SaveGoals(string filename)
    {
 
       if (!File.Exists(filename))
       {

        File.Create(filename).Close();
        Console.WriteLine("Filed created");
       }                  
        using (StreamWriter outputFile = new StreamWriter(filename))
        { 
            foreach( var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score: {_score}");
            Console.WriteLine("Goals Saved");
        }

    }
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
           Console.WriteLine($"Loaded:{line}");
        }
            
        Console.WriteLine("Loaded successfully!");

    }


}    