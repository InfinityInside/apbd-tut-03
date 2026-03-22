namespace apbd_tut_03.SystemUser;

public abstract class SystemUser
{
    private static int _lastIdentifier = 0;
    private int _identifier;
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected SystemUser(string firstName, string lastName)
    {
        _identifier = ++_lastIdentifier;
        FirstName = firstName;
        LastName = lastName;
    }
    
    public virtual int RentalsNumberLimit => 2;

    protected bool Equals(SystemUser other)
    {
        return _identifier == other._identifier;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((SystemUser)obj);
    }

    public override int GetHashCode()
    {
        return _identifier;
    }

    public override string ToString()
    {
        return $"{_identifier} {FirstName} {LastName}";
    }
}