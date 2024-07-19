using System;
namespace EternalQuest{
    class Program
    {
        private readonly static List<string> menuOptions = new List<string>{"Create New Goal","Progress a Goal","Save and Exit"};
        private readonly static List<string> goalOptions = new List<string>{"Simple Goal","Eternal Goal","Checklist Goal"};
        private static bool exit = false;
        public static int points;
        public static GoalList goalList = new();
        static void Main(string[] args)
        {
            goalList.LoadGoalList();
            points = Points.LoadPoints();
            Menu();
            Points.SavePoints(points);
            goalList.SaveGoalList();
            Console.ReadKey();
        }
        private static void Menu(){
            bool loop = true;
            while(loop){
               Console.Clear();
               Console.WriteLine($"   Points: {points}");
               Console.WriteLine("  Eternal Goal Organizer");
               DisplayMenu(menuOptions);
               int choice = GetMenuSelection(0, 2);
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
            foreach(var option in menuOptions){
                Console.WriteLine($"{index}: {option}");
                index++;
            }
        }
        private static int GetMenuSelection(int minChoice, int maxChoice){
            bool loop = true;
            while(loop){
                try{
                    int choice;
                    bool success = int.TryParse(Console.ReadLine(), out choice);
                    if(success && choice <= maxChoice && choice >= minChoice){
                        loop = false;
                        return choice;
                    }else{
                        throw new Exception("Please enter a valid menu option.");
                    }
                }
                catch(Exception e){
                    Console.WriteLine($"Error: {e}");
                }
            }
            return -1;
        }
        private static void ProcessMenuChoice(int choice){
            switch(choice){
                case 0:
                    Console.Clear();
                    DisplayMenu(goalOptions);
                    choice = GetMenuSelection(0, 2);
                    ProcessGoalChoice(choice);
                    break;
                case 1:
                    Console.Clear();
                    List<string> listOfGoals = goalList.ListGoals();
                    DisplayMenu(listOfGoals);
                    choice = GetMenuSelection(0, listOfGoals.Count()-1);
                    ProcessGoalProgressionChoice(choice);
                    break;
                case 2:
                    exit = true;
                    break;
                default:
                    return;
            }
        }
        private static void ProcessGoalChoice(int choice){
            switch(choice){
                case 0:
                    SimpleGoal simpleGoal = new();
                    simpleGoal.CreateGoal();
                    goalList.AddNewGoaltoList(simpleGoal);
                    break;
                case 1:
                    EternalGoal eternalGoal = new();
                    eternalGoal.CreateGoal();
                    goalList.AddNewGoaltoList(eternalGoal);
                    break;
                case 2:
                    ChecklistGoal checklistGoal = new();
                    checklistGoal.CreateGoal();
                    goalList.AddNewGoaltoList(checklistGoal);
                    break;
                default:
                    break;
            }
        }
        private static void ProcessGoalProgressionChoice(int choice){
            Goal goal = goalList.goals[choice];
            if(goal.GoalType == "ChecklistGoal"){
                if(goalList.goals[choice].goalProgress != goalList.goals[choice].goalCap){
                    goalList.goals[choice].goalProgress += 1;
                    points += goal.points;
                    if(goalList.goals[choice].goalProgress == goalList.goals[choice].goalCap){
                        goalList.goals[choice].isCompleted = true;
                        points += goal.points / 2;    
                    }
                }else{
                    Console.WriteLine("This goal has already been completed.");
                    return;
                }
            }else if(goal.GoalType == "EternalGoal"){
                points += goal.points;
                goalList.goals[choice].isCompleted = true;
            }else if(goal.GoalType == "SimpleGoal"){
                if(!goal.isCompleted){
                    points += goal.points;
                    goalList.goals[choice].isCompleted = true;
                }else{
                    Console.WriteLine("This goal has already been completed.");
                    return;
                }
            }
        }
    }
}
