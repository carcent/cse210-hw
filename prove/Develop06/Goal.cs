using System;
using System.Collections.Generic;
using System.Dynamic;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    
    public abstract int GetPoints();

    public virtual bool IsComplete() =>false;
    public virtual string GetDetailsString()
    {
        return $"{_shortName}:{_description}\n You have earned: {_points} Completed {IsComplete()}";
    }

   
    

}