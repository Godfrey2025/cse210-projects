public interface IPerson
{
    global::System.String GetFormalSignature();
    global::System.String GetInformalSignature();
}

public class Person : IPerson
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
    public Person(string title, string firstName, string lastName)
    {
        _title = title;
        _firstName = firstName;
        _lastName = lastName;
    }
}