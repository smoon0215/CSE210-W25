using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an Address object
        Address address = new Address("123 Main St", "Springfield", "IL", "62701");

        // Creating and initializing each event type
        Lecture lecture = new Lecture("Science Lecture", "A lecture on advanced science topics.", new DateTime(2025, 6, 15), "10:00 AM", address, "Dr. John Doe", 100);
        Reception reception = new Reception("Summer Reception", "A summer reception to meet new people.", new DateTime(2025, 7, 20), "5:00 PM", address, "rsvp@example.com");
        Outdoor outdoor = new Outdoor("Picnic in the Park", "Join us for a casual picnic.", new DateTime(2025, 8, 5), "12:00 PM", address, "Sunny, 75°F");

        // Displaying details for each event
        Console.WriteLine("\n\n");

        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Details: ");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n\n");

        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Details: ");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n\n");

        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("\nFull Details: ");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoor.GetShortDescription());
    }
}

