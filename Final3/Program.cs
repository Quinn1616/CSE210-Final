class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Street", "Sacramento", "CA", "USA");
        LectureEvent lectureEvent = new LectureEvent("Lecture Event 1", "Test Lecture Event", "12/15/23", "12:00 PM", address, "Speaker 1", 30);
        Console.WriteLine($"Standard details:\n{lectureEvent.GetStandardDetails()}\n");
        Console.WriteLine($"Full details:\n{lectureEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{lectureEvent.GetShortDescription()}");

        Console.WriteLine("--------------");

        Address address2 = new Address("234 Lane", "Rexburg", "ID", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent("Reception Event 1", "Test Reception Event", "12/20/2023", "5:00 PM", address2, "testemail@gmail.com");
        Console.WriteLine($"Standard details:\n{receptionEvent.GetStandardDetails()}\n");
        Console.WriteLine($"Full details:\n{receptionEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{receptionEvent.GetShortDescription()}");

        Console.WriteLine("--------------");

        Address address3 = new Address("345 Street", "Idaho Falls", "ID", "USA");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Outdoor Event 1", "Test Outdoor Event", "4/1/2024", "12:00 PM", address3, "Sunny");
        Console.WriteLine($"Standard details:\n{outdoorEvent.GetStandardDetails()}\n");
        Console.WriteLine($"Full details:\n{outdoorEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{outdoorEvent.GetShortDescription()}");
    }
}
