namespace EventPlanning{
    public class Lecture : Event{
        public string speakerName;
        public int buildingCapacity;
        public override void FullEventDetails()
        {
            Console.WriteLine($"Lecture:\nSpeaker: {speakerName} - Max Attendance: {buildingCapacity}");
            base.FullEventDetails();
        }
        public override void ShortEventDetails()
        {   
            Console.WriteLine("Lecture:");
            base.ShortEventDetails();
        }
    }
}