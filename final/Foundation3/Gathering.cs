namespace EventPlanning{
    public class Gathering : Event{
        public string weather;
        public override void FullEventDetails()
        {
            Console.WriteLine($"Lecture:\nWeather Forecast: {weather}");
            base.FullEventDetails();
        }
        public override void ShortEventDetails()
        {
            Console.WriteLine("Outdoor Gathering:");
            base.ShortEventDetails();
        }

    }
}