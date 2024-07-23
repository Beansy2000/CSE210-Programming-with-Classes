namespace OnlineOrdering{
    public class Address{
        public string streetAddress;
        public string city;
        public string stateOrProvice;
        public string country;
        public bool IsCountryUSA(){
            if(this.country == "United States of America"){
                return true; 
            }else{
                return false;
            }
        }
        public string FormatAddresstoString(){
           return $"{streetAddress}\n{city}, {stateOrProvice}\n{country}";
        }
    }
}