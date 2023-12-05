class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        Swimming swimming = new Swimming("12/4/2023", 30, 5);
        activity.Add(swimming);

        Running running = new Running("12/5/2023", 60, 2);
        activity.Add(running);

        Biking biking = new Biking("12/6/2023", 45, 15);
        activity.Add(biking);

        foreach (Activity x in activity)
        {
            Console.WriteLine(x.GetSummary());
        }
    }
}
