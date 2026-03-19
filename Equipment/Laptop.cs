using System.Drawing;

namespace apbd_tut_03.Equipment;

public class Laptop : Equipment
{
    public string Processor { get; set; }
    public string Gpu { get; set; }

    public Laptop(string name, Color color, string processor, string gpu) : base(name, color)
    {
        Processor = processor;
        Gpu = gpu;
    }

    public override void Display()
    {
        Console.WriteLine($"Laptop {Name} has Processor {Processor}; Gpu {Gpu}");
        Console.WriteLine("Available: " + IsAvailable);
    }
}