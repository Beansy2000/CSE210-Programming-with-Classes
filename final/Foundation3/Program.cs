using System;
namespace EventPlanning{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address{
                streetAddress = "123 Apple St.",
                city = "New York City",
                stateOrProvice = "New York",
                country = "United States of America"
            };
            Lecture lecture = new Lecture{
                title = "An Introduction to C# Programming",
                description = "An in-depth introduction to class-based programming in the C# language for beginners.",
                date = "July 31st, 2024",
                time = "6:00 PM",
                address = address,
                speakerName = "John Smith",
                buildingCapacity = 80
            };
            Reception reception = new Reception{
                title = "Celebrating the Marriage of John and Jane Smith",
                description = "Wedding Reception following the union of John Smith and Jane Doe. Friends and family welcome.",
                date = "August 1st, 2024",
                time = "4:00 PM",
                address = address,
                rsvpEmail = "john@email.com"
            };
            Gathering gathering = new Gathering{
                title = "Charity Picnic",
                description = "Picnic benefit for (charity). Food tickets are 10$.",
                date = "July 29th, 2024",
                time = "12:00 PM",
                address = address,
                weather = "Partly Cloudy"
            };
            lecture.StandardEventDetails();
            Console.WriteLine();
            lecture.FullEventDetails();
            Console.WriteLine();
            lecture.ShortEventDetails();
            Console.WriteLine();
            reception.StandardEventDetails();
            Console.WriteLine();
            reception.FullEventDetails();
            Console.WriteLine();
            reception.ShortEventDetails();
            Console.WriteLine();
            gathering.StandardEventDetails();
            Console.WriteLine();
            gathering.FullEventDetails();
            Console.WriteLine();
            gathering.ShortEventDetails();
        }
    }
}