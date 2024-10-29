using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activites = new List<Activity>
        {
            new Running(3.0, 30), new StationaryBicycles(12.0, 30), new Swimming(20, 30), new Running(5.0, 35), new StationaryBicycles(15.0, 40), new Swimming(25, 45)
        };

        foreach (var activity in activites)
        {
            Console.WriteLine(activity.GetSumary());
        }
    }
}