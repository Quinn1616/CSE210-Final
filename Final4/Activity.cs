abstract class Activity
{
    public string Date { get; set; }
    public int Length { get; set; }

    public Activity(string date, int length)
    {
        Date = date;
        Length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}