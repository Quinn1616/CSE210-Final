class Event 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }    

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;

    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {GetAddress()}";
    }

    public string GetAddress()
    {
        return $"{Address.Street}, {Address.City} {Address.State}, {Address.Country}";
    }

}