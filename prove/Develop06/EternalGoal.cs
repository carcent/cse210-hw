using System;
using System.ComponentModel;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) :base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
       
    }
    public override int GetPoints () => _points;
    public override string GetStringRepresentation()
    {
        return $"{_shortName} (Eternal) []";
    }
}
