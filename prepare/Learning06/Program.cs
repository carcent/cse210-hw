using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);
        
        Rectangle r1 = new Rectangle("Blue", 2, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 4);
        shapes.Add(c1);
    

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} has an area of {area}");
        }
    }
}