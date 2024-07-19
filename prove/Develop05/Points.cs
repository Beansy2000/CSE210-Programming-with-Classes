namespace EternalQuest{
    public static class Points{
        private static readonly string filename = "./points.csv";
        public static void SavePoints(int points){
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "0");
            }
            List<string> lines = new List<string>{$"{points}"};
            File.WriteAllLines(filename, lines);
        }
        public static int LoadPoints(){
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "0");
            }
            string[] lines = File.ReadAllLines(filename);
            return int.Parse(lines[0]);
        }
    }
}