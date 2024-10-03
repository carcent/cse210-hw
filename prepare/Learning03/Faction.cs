using System;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    
    private int _top;
    private int _bottom;

    

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int entNumber)
    {
        _top = entNumber;
        _bottom = 1;
    }
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string frct = _top + "/" + _bottom;
        return frct;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}