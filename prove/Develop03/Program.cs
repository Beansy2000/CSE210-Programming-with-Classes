using System;
using System.Diagnostics;
using System.Security.Cryptography;
namespace ScriptureMemorizer{
    class Program
    {
        private static readonly List<string> menuOptions = ["Store a New Scripture", "Select a Scripture to Memorize", "Quit"];
        private static bool exit = false;
        public static ScriptureList scriptureList = new();
        static void Main(string[] args)
        {
            scriptureList.LoadScriptures();
            Menu();
        }

        private static void Menu(){
            bool loop = true;
            while(loop){
                Console.Clear();
                DisplayMenu(menuOptions);
                int choice = GetMenuSelection();
                if(choice != -1){
                    ProcessMenuChoice(choice);
                }
                if(exit == true){
                    loop = false;
                }else{
                    Console.ReadLine();
                }
            }
        }

        private static void DisplayMenu(List<string> menuOptions){
            int index = 0;
            Console.WriteLine("  Scripture Memorizer");
            foreach(var option in menuOptions){
                Console.WriteLine($"[{index}]: {option}");
                index++;
            }
        }
        private static int GetMenuSelection(){
            bool loop = true;
            while(loop){
                try{
                    string choice = Console.ReadLine();
                    int choiceInt = int.Parse(choice);
                    if(menuOptions[choiceInt] is not null){
                        loop = false;
                        return choiceInt;
                    }
                    else{
                        throw new Exception("Please enter a valid menu option.");
                    }
                }
                catch (Exception e){
                    Console.WriteLine($"Error: {e}");
                    loop = false;
                    return -1;
                }
            }
            return -1;
        }
        public static void ProcessMenuChoice(int choice){
            switch(choice){
                case 0:
                    scriptureList.AddNewScripturetoList();
                    break;
                case 1:
                    Memorize.MemorizeScriptures(scriptureList);
                    break;
                case 2:
                    exit = true;
                    break;
                default:
                    return;
            }
        }
    }
}
/*
 



  */