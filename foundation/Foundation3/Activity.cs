using System;


public abstract class Activity
{
    private string _name; 
    protected int _duration;
    protected DateTime _date;

    protected Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
        _date = DateTime.Now;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double  GetPace()
    {
        return 0;
    }
    public virtual string GetSumary()
    {
        return $"{_date: dd MM yyyy} {_name} ({_duration} min): Distance {GetDistance()} Km, Speed: {GetSpeed():F2} kph, Pace: {GetPace()} min per km";
    }
    
     
}