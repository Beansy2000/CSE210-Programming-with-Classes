namespace EternalQuest{
    public class ChecklistGoal : Goal{
        public override void CreateGoal()
        {
            bool loop = true;
            while(loop){
                Console.WriteLine("What will you name your Checklist Goal?\nWhat is the goal? Ex: 'Make friends with your roommates.");
                this.goalName = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(this.goalName)){
                    this.goalName = "NoName";
                }
                if(!string.IsNullOrWhiteSpace(this.goalName)){
                    break;  
                }
            }
            while(loop){
                Console.WriteLine("How many points will your goal be worth?\nHow many points you get each time you do it.");
                bool success = int.TryParse(Console.ReadLine(), out this.points);
                if(success){
                    break;
                }else{
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            while(loop){
                Console.WriteLine("How many times would you like to do this goal?");
                bool success = int.TryParse(Console.ReadLine(), out this.goalCap);
                if(success){
                    loop = false;
                }else{
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}