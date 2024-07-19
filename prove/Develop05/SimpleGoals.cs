namespace EternalQuest{
    public class SimpleGoal : Goal{
        public override void CreateGoal()
        {
            bool loop = true;
            while(loop){
                Console.WriteLine("What will you name your Simple Goal?\nWhat is the goal? Ex: 'Save up to buy something.");
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