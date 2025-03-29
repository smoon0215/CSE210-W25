public class Customer
{
    private string name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this._address = address;
    }

    public bool InUSA()
    {
        return _address.IsInUSA();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
}