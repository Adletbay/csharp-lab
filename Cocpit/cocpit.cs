using System;

public class Cocpit
{
    Button button { get; set; }
    Sensor sensor { get; set; }
    Lever lever {get; set;}
    
    public void Print()
    {
        Console.WriteLine("Рабочая панель создана!");
    }
}