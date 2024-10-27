using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
      
       _isComplete = false;

    }

    public override void RecordEvent()
    {
          if (!_isComplete)
        {
            _isComplete = true;
        }
        
    }
    
    public override bool IsComplete() => _isComplete;

    public override int GetPoints() => _isComplete ? _points : 0;

    public override string GetStringRepresentation()
    {
        return $"{_shortName} (Simple [{(_isComplete ? "X" : " ")}])";
    }
    
}