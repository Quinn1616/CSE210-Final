class Customer
{
    public string Name { get; set; }
    public Address AddressLocation { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        AddressLocation = address;
    }

    public bool InUS()
    {
        return AddressLocation.InUS();
    }
}