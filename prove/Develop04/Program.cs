using System;
using System.Diagnostics;

namespace Mindfulness{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop){
                Console.Clear();
                DisplayOptions();
                var choice = GetActivityChoice();
                if(choice != 0){
                    var quit = RunChosenActivity(choice);
                    if(quit == 1){
                        loop = false;
                        return;
                    }
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }
        static void DisplayOptions(){
            Console.WriteLine("Please select one of the following activities:");
            Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
        }
        static int GetActivityChoice(){
            bool loop = true;
            while(loop){
                try{
                    int choice;
                    bool success = int.TryParse(Console.ReadLine(), out choice);
                    if(success == true && choice > 0 && choice < 5){
                        loop = false;
                        return choice;
                    }else{
                        throw new Exception("Not a valid menu option.");
                    }
                }
                catch(Exception exception){
                    Console.WriteLine($"Error: {exception}");
                    loop = false;
                    return 0;
                }
            }
            return 0;
        }
        static int RunChosenActivity(int choice){
            int duration;  
            switch(choice){
                case 1:
                    duration = GetActivityDuration();   
                    BreathingActivity breathingActivity = new(duration);
                    breathingActivity.OpeningMessage();
                    breathingActivity.BeginActivity();
                    breathingActivity.ClosingMessage();
                    return 0;
                case 2:
                    duration = GetActivityDuration();  
                    ReflectionActivity reflectionActivity = new(duration);
                    reflectionActivity.OpeningMessage();
                    reflectionActivity.BeginActivity();
                    reflectionActivity.ClosingMessage();
                    return 0;
                case 3:
                    duration = GetActivityDuration();  
                    ListingActivity listingActivity = new(duration);
                    listingActivity.OpeningMessage();
                    listingActivity.BeginActivity();
                    listingActivity.ClosingMessage();
                    return 0;
                case 4:
                    return 1;
                default:
                    return 0;
            }
        }
        static int GetActivityDuration(){
            Console.WriteLine("How long would you like to set the duration of this activity? (in seconds): ");
            bool loop = true;
            while(loop){
                try{
                    int time;
                    bool success = int.TryParse(Console.ReadLine(), out time);
                    if(success == true){
                        loop = false;
                        return time;
                    }else{
                        throw new Exception("Input was not a valid integer.");
                    }
                }
                catch(Exception exception){
                    Console.WriteLine($"Error: {exception}");
                }
            }
            return 0;
        }
    }
}