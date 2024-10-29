using System;

public class Running : Activity
{
    private double _distance;

    public Running(double distance, int duration) : base("Running", duration)
    {
        _distance = distance;
    }
    public override double GetDistance() 
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / _duration *60;
        return speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? _duration/ distance : 0;
    }
   
}