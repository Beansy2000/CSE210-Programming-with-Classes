using System;
namespace OnlineOrdering{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order{
                orderList = new List<Product>(),
                customer = new Customer{
                    name = "Boston",
                    address = new Address{
                        streetAddress = "123 Apple St.",
                        city = "New York City",
                        stateOrProvice = "New York",
                        country = "United States of America"
                    }
                }
            };
            Order order2 = new Order{
                orderList = new List<Product>(),
                customer = new Customer{
                    name = "Notsob",
                    address = new Address{
                        streetAddress = "321 Banana Blvd.",
                        city = "City",
                        stateOrProvice = "Province",
                        country = "Canada"
                    }
                }
            };
            order1.orderList = new List<Product>{
                new Product{
                    name = "Happy T-Shirt",
                    productID = "tee-136",
                    price = 2150,
                    quantity = 1
                },
                new Product{
                    name = "Apple T-Shirt",
                    productID = "tee-121",
                    price = 1849,
                    quantity = 2
                }
            };
            order2.orderList = new List<Product>{
                new Product{
                    name = "Banana Jacket",
                    productID = "jac-063",
                    price = 2899,
                    quantity = 1
                },
                new Product{
                    name = "Smile Baseball Cap",
                    productID = "bcp-082",
                    price = 1199,
                    quantity = 1
                },
                new Product{
                    name = "Happy T-Shirt",
                    productID = "tee-136",
                    price = 2150,
                    quantity = 1
                }
            };
            Console.WriteLine(order1.PackingLabel());
            Console.WriteLine();
            Console.WriteLine(order1.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"${(float) order1.TotalPrice() / 100}");
            Console.WriteLine();
            Console.WriteLine(order2.PackingLabel());
            Console.WriteLine();
            Console.WriteLine(order2.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"${(float) order2.TotalPrice() / 100}");
        }
    }
}