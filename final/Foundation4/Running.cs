namespace ExerciseTracking{
    public class Running : Exercise{
        public double distance;
        protected override string NameActivity()
        {
            return "Running";
        }
        protected override double oDistance()
        {
            return distance;
        }
        protected override double oPace()
        {
            return durationOfActivity / oDistance();
        }
        protected override double oSpeed()
        {
            return 60 / oPace();
        }
    }
}