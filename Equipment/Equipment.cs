namespace apbd_tut_03.Equipment;

public abstract class Equipment
{
    private static int _lastIdentifier = 0;
    
    private int _identifier;
    
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    protected Equipment(string name)
    {
        _identifier = ++_lastIdentifier;
        Name = name;
    }
    
}