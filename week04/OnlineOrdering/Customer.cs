public class Customer
{
    private string _name;
    private string _address;
    private string _email;

    public Customer(string name, string address, string email)
    {
        _name = name;
        _address = address;
        _email = email;
    }

    public string GetName() => _name;
    public string GetAddress() => _address;
    public string GetEmail() => _email;

    public bool LivesInUSA()
    {
        // Simple check: does the address contain "USA"?
        return _address.ToUpper().Contains("USA");
    }
}