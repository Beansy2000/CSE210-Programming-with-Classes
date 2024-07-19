namespace EternalQuest{
    public class EternalGoal : Goal{
        public override void CreateGoal()
        {
            bool loop = true;
            while(loop){
                Console.WriteLine("What will you name your Eternal Goal?\nWhat is the goal? Ex: 'Wake up at 7AM.");
                this.goalName = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(this.goalName)){
                    this.goalName = "NoName";
                }
                if(!string.IsNullOrWhiteSpace(this.goalName)){
                    break;  
                }
            }
            while(loop){
                Console.WriteLine("How many points will your goal be worth?");
                bool success = int.TryParse(Console.ReadLine(), out this.points);
                if(success){
                    loop = false;
                }else{
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}