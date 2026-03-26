public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool livesInUSA()
    {
        return address.isInUSA();
    }

    public string getName()
    {
        return name;
    }

    public string getAddress()
    {
        return address.getAddress();
    }
}