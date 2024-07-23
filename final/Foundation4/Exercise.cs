namespace ExerciseTracking{
    public abstract class Exercise{
        public string date;
        public int durationOfActivity;
        protected abstract string NameActivity();
        protected abstract double oDistance();
        protected abstract double oSpeed();
        protected abstract double oPace();
        public void GetSummary(){
            Console.WriteLine($"{date} {NameActivity()}: Distance: {oDistance().ToString("0.00")} miles, Speed: {oSpeed()} mph, Pace: {oPace().ToString("0")} min per mile");
        }
    }
}