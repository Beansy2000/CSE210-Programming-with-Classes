namespace Mindfulness
{
    public abstract class Activity{
        public int _duration;
        protected string _name;
        protected string _description;
        public Activity(int duration){
            this._duration = duration;
        }
        public virtual void OpeningMessage(){
            Console.Clear();
            Console.WriteLine($"{_name}\n{_description}\nPlease take a moment to prepare. The activity will begin in: ");
            PauseAnimation_Countdown(5);
        }
        public virtual void ClosingMessage(){
            Console.Clear();
            Console.WriteLine($"Great job!\nYou did the {_name} for at least {_duration} second(s)!");
            PauseAnimation_Smile(5);
        }
        public abstract void BeginActivity();
        protected void PauseAnimation_Countdown(int _seconds){
            while(_seconds > 0){
                Console.Write(_seconds);
                System.Threading.Thread.Sleep(1000);
                ClearLine();
                _seconds -= 1;
            }
        }
        protected void PauseAnimation_Smile(int _seconds){
            while(_seconds > 0){
                Console.Write("(");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write("＾");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write("v");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write("＾");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write(")");
                System.Threading.Thread.Sleep(2000);
                _seconds -= 2;
            }
        }
        protected void PauseAnimation_Dots(int _seconds){
            while(_seconds > 0){
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                _seconds -= 1;
                ClearLine();
            }
        }
        private void ClearLine(){
            int _currentLine = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, _currentLine);
        }

    }
}