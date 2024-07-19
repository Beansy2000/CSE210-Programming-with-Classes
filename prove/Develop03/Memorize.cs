namespace ScriptureMemorizer
{
    public class Memorize{
        public static void MemorizeScriptures(ScriptureList scriptureList){
            bool loop = true;
            while(loop){
                Console.Clear();
                DisplayScriptureReferences(scriptureList);
                var choice = GetScriptureSelection(scriptureList);
                if(choice == -2){
                    loop = false;
                    return;
                }else if(choice >= 0){
                    MemorizeScripture(scriptureList.scriptures[choice]);
                }

            }
        }
        private static void DisplayScriptureReferences(ScriptureList scriptureList){
            int index = 0;
            Console.WriteLine("  Select a Scripture to Memorize.");
            foreach(Scripture scripture in scriptureList.scriptures){
                Console.WriteLine($"[{index}]: {scripture.reference.text}");
                index++;
            }
            Console.WriteLine($"[{index}]: Quit");
        }
        private static int GetScriptureSelection(ScriptureList scriptureList){
            bool loop = true;
            while(loop){
                try{
                    string choice = Console.ReadLine();
                    int choiceInt = int.Parse(choice);
                    if(choiceInt == scriptureList.scriptures.Count()){
                        loop = false;
                        return -2;
                    }else if(scriptureList.scriptures[choiceInt] is not null){
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
        private static void MemorizeScripture(Scripture scripture){
            List<Word> words = new();
            string[] splitString = scripture.scriptureText.Split(" ");
            foreach(string word in splitString){
                Word newWord = new Word(){
                    text = word,
                    hiddenText = new string('_', word.Length)
                };
                Console.WriteLine(word.Count());
                words.Add(newWord);
            }
            bool loop = true;
            while(loop){
                Console.Clear ();
                Console.WriteLine("Press Enter to hide a random word. Type Quit to exit.");
                foreach(Word word in words){
                    if(word.isHidden == true){
                        Console.Write($"{word.hiddenText} ");
                    }else{
                        Console.Write($"{word.text} ");
                    }
                }
                var input = Console.ReadLine();
                if(input.ToLower() == "quit"){
                    loop = false;
                    return;
                }else{
                    HideRandomWord(ref words);
                }   
            }
        }
        private static void HideRandomWord(ref List<Word> words){
            if(AreAllWordsHidden(words)){
                return;
            }
            Random random = new Random();
            var rand = random.Next(0, words.Count());
            if(!words[rand].isHidden){
                words[rand].isHidden = true;
            }else{
                HideRandomWord(ref words);
            }
        }
        private static bool AreAllWordsHidden(List<Word> words){
            foreach(Word word in words){
                if(!word.isHidden){
                    return false;
                }
            }
            return true;
        }
    }
}