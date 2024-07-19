namespace ScriptureMemorizer{
    public class Scripture{
        public Reference reference;
        public string scriptureText;
        
        public static Scripture NewScripture(){
            Reference reference = Reference.NewReference();
            string scriptureText = GetScriptureText();
            Scripture scripture = new Scripture(){
                reference = reference,
                scriptureText = scriptureText
            };

            return scripture;
        }
        private static string GetScriptureText(){
            bool loop = true;
            while(loop){
                Console.Clear();
                Console.WriteLine("Please enter the scripture text.");      
                string text = Console.ReadLine();
                Console.WriteLine("Are you sure that the text is correct? (yes)");
                string doubleCheck = Console.ReadLine();
                if(doubleCheck.ToLower() == "yes"){
                    loop = false;
                    return text;    
                }
            }
            return "";
        }
    }
}