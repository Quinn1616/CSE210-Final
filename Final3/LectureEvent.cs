class LectureEvent : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capactity) : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capactity;
    }

    public string GetFullDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {GetAddress()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public string GetShortDescription()
    {
        return $"Type: Lecture Event\nTitle: {Title}\nDate: {Date}";
    }

    
}