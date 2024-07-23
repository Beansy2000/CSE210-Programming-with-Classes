namespace EventPlanning{
    public abstract class Event{
        public string title;
        public string description;
        public string date;
        public string time;
        public Address address;
        public virtual void StandardEventDetails(){
            Console.WriteLine($"{title}\n{description}\n{date}/{time}\n{address.FormatAddresstoString()}");
        }
        public virtual void FullEventDetails(){
            Console.WriteLine($"{title}\n{description}\n{date}/{time}\n{address.FormatAddresstoString()}");            
        }
        public virtual void ShortEventDetails(){
            Console.WriteLine($"{title}\n{date}");    
        }
    }
}