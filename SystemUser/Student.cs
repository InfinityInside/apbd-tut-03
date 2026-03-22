namespace apbd_tut_03.SystemUser;

public class Student : SystemUser

{
    public Student(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    public override string ToString()
    {
        return "Employee " + base.ToString();
    }
}