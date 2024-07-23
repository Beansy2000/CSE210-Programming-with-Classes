namespace ExerciseTracking{
    public class Swimming : Exercise{
        public double laps;
        protected override string NameActivity()
        {
            return "Swimming Laps";
        }
        protected override double oDistance()
        {
            
            return laps * 50 * 0.62 / 1000;
        }
        protected override double oPace()
        {
            return durationOfActivity / oDistance();
        }
        protected override double oSpeed()
        {
            return oDistance() / durationOfActivity * 60;
        }
    }
}