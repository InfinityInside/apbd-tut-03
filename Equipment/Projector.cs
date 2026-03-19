using System.Drawing;

namespace apbd_tut_03.Equipment;

public class Projector : Equipment
{
    public int Brightness { get; set; }
    public string AspectRatio { get; private set; }

    public Projector(string name, Color color, int brightness, string aspectRatio) : base(name, color)
    {
        Brightness = brightness;
        AspectRatio = aspectRatio;
    }

    public override void Display()
    {
        Console.WriteLine($"Projector {Name} has brightness {Brightness}; Aspect ratio {AspectRatio}");
        Console.WriteLine("Available: " + IsAvailable);
    }
}