class ReceptionEvent : Event
{
    public string RsvpEmail { get; set; }

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        RsvpEmail = email;
    }

    public string GetFullDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {GetAddress()}\nEmail: {RsvpEmail}";
    }

    public string GetShortDescription()
    {
        return $"Type: Reception Event\nTitle: {Title}\nDate: {Date}";
    }
    
}