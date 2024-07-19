namespace EternalQuest{
    public abstract class Goal{
        public string goalName;
        public int points;
        public bool isCompleted = false;
        public int goalProgress;
        public int goalCap;
        private string goalType;
        public string GoalType { 
            get{
                return goalType;
            }
            set{
                goalType = value;
            }
        }
        public Goal(){
            GoalType = this.GetType().Name;
        }
        public abstract void CreateGoal();
    }
}