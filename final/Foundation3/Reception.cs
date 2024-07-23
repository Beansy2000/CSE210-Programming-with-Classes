namespace EventPlanning{
    public class Reception : Event{
        public string rsvpEmail;
        public override void FullEventDetails()
        {
            Console.WriteLine($"Reception:\nRSVP to: {rsvpEmail}");
            base.FullEventDetails();
        }
        public override void ShortEventDetails()
        {
            Console.WriteLine("Reception:");
            base.ShortEventDetails();
        }

    }
}