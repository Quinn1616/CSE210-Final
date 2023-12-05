class Running : Activity
{
    public double Distance { get; set; }

    public Running(string date, int length, double distance) : base(date, length)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Length) * 60;
    }

    public override double GetPace()
    {
        return Math.Round(Length / Distance, 2);
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({Length} min) - Distance {Distance} miles, Speed {GetSpeed()} mph, Pace {GetPace()} minutes per mile";
    }
}