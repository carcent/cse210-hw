using System;
using System.ComponentModel;

public class NegativeGoal : Goal
{
    private bool _isComplete;

    public NegativeGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete( ) => _isComplete;
        public override int GetPoints()
    {
        return _isComplete ? 0 : -_points; 
    }
    

    public override string GetStringRepresentation()
    {
        return $"{_shortName} Loss points [{(_isComplete ? "X" : " ")}]";
    }
}
