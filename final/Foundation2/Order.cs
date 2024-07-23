namespace OnlineOrdering{
    public class Order{
        public List<Product> orderList = new List<Product>();
        public Customer customer;
        public int TotalPrice(){
            int totalSum = 0;
            foreach(Product product in orderList){
                totalSum += product.TotalCost();
            }
            if(customer.isAmerican){
                totalSum += 500;
            }else{
                totalSum += 3500;
            }
            return totalSum;
        }
        public string PackingLabel(){
            string label = "";
            foreach(Product product in orderList){
                label = $"{label}\n{product.name} - {product.productID}";
            }
            return label;
        }
        public string ShippingLabel(){
            return $"{customer.name}\n{customer.address.FormatAddresstoString()}";
        }
    }
}