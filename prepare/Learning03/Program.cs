using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frc1 = new Fraction();
        Console.WriteLine(frc1.GetFractionString());
        Console.WriteLine(frc1.GetDecimalValue());

        
        Fraction frc2 = new Fraction(5);
        Console.WriteLine(frc2.GetFractionString());
        Console.WriteLine(frc2.GetDecimalValue());

        
        Fraction frc3 = new Fraction(3, 4);
        Console.WriteLine(frc3.GetFractionString());
        Console.WriteLine(frc3.GetDecimalValue());

        
        Fraction frc4 = new Fraction(1, 3);
        Console.WriteLine(frc4.GetFractionString());
        Console.WriteLine(frc4.GetDecimalValue());
    }
}