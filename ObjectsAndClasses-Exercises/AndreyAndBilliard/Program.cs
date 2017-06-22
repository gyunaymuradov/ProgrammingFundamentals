using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var productPriceDict = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var productPrice = Console.ReadLine().Split('-').ToArray();
                var product = productPrice[0];
                var price = decimal.Parse(productPrice[1]);

                productPriceDict[product] = price;
            }

            var customersList = new List<Customer>();
            var clientsList = Console.ReadLine();
            while (clientsList != "end of clients")
            {
                var tokens = clientsList.Split('-').ToArray();
                var name = tokens[0];
                var productQuantity = tokens[1].Split(',').ToArray();
                var product = productQuantity[0];
                var quantity = int.Parse(productQuantity[1]);

                if (!productPriceDict.ContainsKey(product))
                {
                    clientsList = Console.ReadLine();
                    continue;
                }

                Customer currentCustomer = new Customer();
                currentCustomer.Name = name;
                currentCustomer.ShopList = new Dictionary<string, int>();
                currentCustomer.ShopList.Add(product, quantity);

                if (customersList.Any(a => a.Name == name))
                {
                    Customer existingCustomer = customersList.First(a => a.Name == name);
                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }
                else
                {
                    customersList.Add(currentCustomer);
                }
                clientsList = Console.ReadLine();
            }
            foreach (Customer customer in customersList)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in productPriceDict) 
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += (double)(item.Value * product.Value);
                        }
                    }
                }
            }
            var totalBill = 0.0;
            foreach (Customer customer in customersList.OrderBy(a => a.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public double Bill { get; set; }
    }
}