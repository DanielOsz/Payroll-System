public abstract class Employee
{
    private string FirstName { get;  set;}
    private string LastName { get;  set;}
    private string SocialSecurityNumber { get;  set; }

    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    }


    public override string ToString()
    {
        return string.Format(" {0} {1}\n social secuurity number: {2}",
            FirstName, LastName, SocialSecurityNumber);
    }

    public abstract decimal Earnings();
}