namespace ScriptureMemorizer{
    public  class ScriptureList{
        private readonly static string filename = "./scriptures.csv";
        public List<Scripture> scriptures = new();

        public void LoadScriptures(){
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "");
            }
            string[] lines = File.ReadAllLines(filename);
            foreach(string line in lines){
                var sections = line.Split(".,.");
                var reference = Reference.Parse(sections[0]);
                Scripture scripture = new Scripture {
                    reference = reference,
                    scriptureText = sections[1]
                };
                scriptures.Add(scripture);
            }
        }
        public void SaveScriptures(){
            List<string> lines = new();
            if(!File.Exists(filename)){
                File.WriteAllText(filename, "");
            }
            foreach(Scripture scripture in scriptures){
                lines.Add($"{scripture.reference.text}.,.{scripture.scriptureText}");
            }
            File.WriteAllLines(filename, lines);
        }

        public void AddNewScripturetoList(){
            Scripture scripture = Scripture.NewScripture();
            scriptures.Add(scripture);
            SaveScriptures();
        }
    }
}