class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool InUS()
    {
        if (Country == "USA")
        {
            return true;
        }

        else 
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{Street}\n{City}, {State} {Country}";
    }
}