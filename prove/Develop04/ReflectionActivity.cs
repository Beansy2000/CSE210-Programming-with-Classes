namespace Mindfulness{
    public class ReflectionActivity : Activity{
        private string[] _reflectionList = {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private string[] _promptList = {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless."
        };

        public ReflectionActivity(int duration) : base(duration)
        {
            this._duration = duration;
            this._name = "Reflection Activity";
            this._description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

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
            Console.Clear();
            var countdown = _duration;
            Console.WriteLine(GetPrompt());
            while(countdown > 0){
                PauseAnimation_Dots(9);
                Console.WriteLine($"\n{GetReflection()}\n");
                PauseAnimation_Dots(12);
                countdown -= 21;
            }
        }
        private string GetPrompt(){
            Random rand = new();
            int index = rand.Next(0, _promptList.Count()-1);
            return _promptList[index];
        }
        private string GetReflection(){
            Random rand = new();
            int index = rand.Next(0, _reflectionList.Count()-1);
            return _reflectionList[index];
        }
    }
}