namespace OnlineOrdering{
    public class Product{
        public string name;
        public string productID;
        public int price;
        public int quantity;
        public int TotalCost(){
            return price * quantity;
        }
    }
}