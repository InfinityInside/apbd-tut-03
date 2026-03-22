namespace apbd_tut_03.SystemUser;

public class Employee : SystemUser
{
    
    public Employee(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override int RentalsNumberLimit => 5;
}