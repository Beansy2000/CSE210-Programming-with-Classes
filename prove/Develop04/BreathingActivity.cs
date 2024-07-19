namespace Mindfulness{
    public class BreathingActivity : Activity{

        public BreathingActivity(int duration) : base(duration)
        {
            this._duration = duration;
            this._name = "Breathing Activity";
            this._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        public override void OpeningMessage()
        {
            base.OpeningMessage();
        }
        public override void ClosingMessage()
        {
            base.ClosingMessage();
        }
        public override void BeginActivity()
        {
            var countdown = _duration;
            while(countdown > 0){
                Console.Clear();
                Console.WriteLine("Breathe in...");
                PauseAnimation_Dots(5);
                Console.WriteLine("Breathe out...");
                PauseAnimation_Dots(5);
                countdown -= 10;
            }
        }
    }
}