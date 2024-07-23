namespace OnlineOrdering{
    public class Customer{
        public string name;
        public Address address;
        public bool isAmerican{ 
            get{   
                return address.IsCountryUSA();
            }
        }
    }
}