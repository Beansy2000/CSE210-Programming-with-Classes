namespace EventPlanning{
    public class Address{
        public string streetAddress;
        public string city;
        public string stateOrProvice;
        public string country;
        public string FormatAddresstoString(){
           return $"{streetAddress}\n{city}, {stateOrProvice}\n{country}";
        }
    }
}