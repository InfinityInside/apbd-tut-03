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
}