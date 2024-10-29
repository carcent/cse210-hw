using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, int duration) : base ("Swimming", duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double distance = _laps*50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance()/_duration *60;
        return speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? _duration/ distance : 0;
    }
}