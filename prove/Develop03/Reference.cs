using System.Net.NetworkInformation;

namespace ScriptureMemorizer{   
    public class Reference{
        public string text;

        public static Reference Parse(string referenceText){
            Reference reference = new Reference{
                text = referenceText
            };
            return reference;
        }
        public static Reference NewReference(){
            string referenceText = GetReferenceText();
            Reference reference = new Reference(){
                text = referenceText
            };

            return reference;
        }
        private static string GetReferenceText(){
            bool loop = true;
            while(loop){
                Console.Clear();
                Console.WriteLine("Please enter the reference text.");      
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