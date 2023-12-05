class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60.0;
    }

    public override double GetPace()
    {
        return Math.Round(Length / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({Length} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} minutes per mile";
    }
}