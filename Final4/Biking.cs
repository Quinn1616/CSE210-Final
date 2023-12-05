class Biking : Activity 
{
    public double Speed { get; set; }

    public Biking(string date, int length, double speed) : base(date, length)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * Length / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return Math.Round(Length / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return $"{Date} Biking ({Length} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} minutes per mile";
    }
}