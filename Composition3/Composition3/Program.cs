using System;
using Composition3.Entities;
using Composition3.Entities.Enums;
using System.Globalization;

namespace Composition3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);


            Console.Write("Enter order data: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status , client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + "item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName , productPrice);
                OrderItem orderItem = new OrderItem(quantity , product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("");
            Console.WriteLine(order);


        }
    }
}
