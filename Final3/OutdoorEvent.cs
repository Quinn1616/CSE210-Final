class OutdoorEvent : Event
{
    public string Weather { get; set; }

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public string GetFullDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {GetAddress()}\nWeather: {Weather}";
    }

    public string GetShortDescription()
    {
        return $"Type: Outdoor Event\nTitle: {Title}\nDate: {Date}";
    }
}