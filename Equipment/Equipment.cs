using System.Drawing;

namespace apbd_tut_03.Equipment;

public abstract class Equipment
{
    private static int _lastIdentifier = 0;
    
    private int _identifier;
    
    public string Name { get; set; }
    
    public Color Color { get; set; }
    public bool IsAvailable { get; set; }

    protected Equipment(string name, Color color)
    {
        _identifier = ++_lastIdentifier;
        Name = name;
        Color = color;
    }

    public abstract void Display();

}