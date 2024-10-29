using System;

public class StationaryBicycles : Activity
{
    private double _speed;
    public StationaryBicycles (double speed, int duration) : base("Stationary Bicycle",duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double distance = _speed * _duration / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? _duration/ distance : 0;
    }

}