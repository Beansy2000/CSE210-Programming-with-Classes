namespace Mindfulness{
    public class ListingActivity : Activity{

        public ListingActivity(int duration) : base(duration)
        {
            this._duration = duration;
            this._name = "Listing Activity";
            this._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        private string[] _listPrompts = {
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
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
            Console.Clear();
            var countdown = _duration;
            Console.WriteLine(GetListPrompt());
            while(countdown > 0){
                PauseAnimation_Dots(8);
                Console.WriteLine("\nKeep listing! You can do it!\n");
                PauseAnimation_Dots(8);
                countdown -= 16;
            }
        }
        private string GetListPrompt(){
            Random rand = new();
            int index = rand.Next(0, _listPrompts.Count()-1);
            return _listPrompts[index];
        }
    }
}