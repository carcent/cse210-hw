using System;
using System.Dynamic;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

}