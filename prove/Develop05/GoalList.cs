namespace EternalQuest{
    public class GoalList{
        private readonly string filename = "./GoalList.csv";
        public List<Goal> goals = new List<Goal>();

        public void SaveGoalList(){
            List<string> lines = new();
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "");
            }
            foreach(Goal goal in goals){
                var line = $"{goal.isCompleted}.,.{goal.GoalType}.,.{goal.goalName}.,.{goal.points}";
                if(goal.GoalType == "ChecklistGoal"){
                    line = $"{line}.,.{goal.goalProgress}.,.{goal.goalCap}";
                }
                lines.Add(line);
            }
            File.WriteAllLines(filename, lines);
        }
        public void LoadGoalList(){
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "");
            }
            string[] lines = File.ReadAllLines(filename);
            foreach(string line in lines){
                var sections = line.Split(".,.");
                if(sections[1] == "SimpleGoal"){
                    SimpleGoal simpleGoal = new SimpleGoal(){
                        isCompleted = bool.Parse(sections[0]),
                        GoalType = sections[1],
                        goalName = sections[2],
                        points = int.Parse(sections[3]),
                    };
                    goals.Add(simpleGoal);
                }else if(sections[1] == "EternalGoal"){
                    EternalGoal eternalGoal = new EternalGoal(){
                        isCompleted = bool.Parse(sections[0]),
                        GoalType = sections[1],
                        goalName = sections[2],
                        points = int.Parse(sections[3]),
                    };
                    goals.Add(eternalGoal);
                }else if(sections[1] == "ChecklistGoal"){
                    ChecklistGoal ChecklistGoal = new ChecklistGoal(){
                        isCompleted = bool.Parse(sections[0]),
                        GoalType = sections[1],
                        goalName = sections[2],
                        points = int.Parse(sections[3]),
                        goalProgress = int.Parse(sections[4]),
                        goalCap = int.Parse(sections[5]),
                    };
                    goals.Add(ChecklistGoal);
                }
            }
        }
        public void AddNewGoaltoList(Goal goal){
            this.goals.Add(goal);
        }
        public List<string> ListGoals(){
            List<string> lines = new List<string>{};
            foreach(Goal goal in goals){
                if(goal.GoalType == "ChecklistGoal"){
                    if(goal.isCompleted){
                        lines.Add($"[X]    {goal.GoalType}: {goal.goalName} ~{goal.points}");
                    }else{
                        lines.Add($"[{goal.goalProgress}/{goal.goalCap}] {goal.GoalType}: {goal.goalName} ~{goal.points}");
                    }
                }else{
                    lines.Add($"[{(goal.isCompleted ? 'X': ' ')}]    {goal.GoalType}: {goal.goalName} ~{goal.points}");
                }
            }
            return lines;
        }
    }
}