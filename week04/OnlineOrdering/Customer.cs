public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool livesInUSA()
    {
        return _address.isInUSA();
    }

    public string getName()
    {
        return _name;
    }

    public string getAddress()
    {
        return _address.getAddress();
    }
}