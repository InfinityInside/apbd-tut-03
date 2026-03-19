using System.Drawing;

namespace apbd_tut_03.Equipment;

public class Camera : Equipment
{
    public int MaxMagnification { get; set; }
    public bool HasHdr { get; set; }

    public Camera(string name, Color color, int maxMagnification, bool hasHdr) : base(name, color)
    {
        MaxMagnification = maxMagnification;
        HasHdr = hasHdr;
    }

    public override void Display()
    {
        Console.WriteLine($"Camera {Name} has maximum magnification {MaxMagnification};{(HasHdr ? " has HDR" : "")}");
        Console.WriteLine("Available: " + IsAvailable);
    }
}