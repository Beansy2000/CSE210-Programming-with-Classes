namespace ExerciseTracking{
    public class Biking : Exercise{
        public double speed;
        protected override string NameActivity()
        {
            return "Stationary Bike";
        }
        protected override double oDistance()
        {
            return durationOfActivity / oPace();
        }
        protected override double oPace()
        {
            return 60 / oSpeed();
        }
        protected override double oSpeed()
        {
            return speed;
        }
    }
}