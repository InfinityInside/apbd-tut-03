using System.Drawing;

namespace apbd_tut_03.Equipment;

public abstract class Equipment
{
    private static int _lastIdentifier = 0;
    
    private int _identifier;
    
    public string Name { get; set; }
    
    public Color Color { get; set; }
    public bool IsAvailable { get; set; }

    public virtual double PerDayFee => 10d;

    protected Equipment(string name, Color color)
    {
        _identifier = ++_lastIdentifier;
        Name = name;
        Color = color;
    }

    public abstract void Display();

    protected bool Equals(Equipment other)
    {
        return _identifier == other._identifier;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Equipment)obj);
    }

    public override int GetHashCode()
    {
        return _identifier;
    }

    public override string ToString()
    {
        return $"{_identifier} {Name} {Color} {(IsAvailable ? "" : "Not ")} Available";
    }
}