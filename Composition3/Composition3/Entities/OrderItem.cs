using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition3.Entities;

namespace Composition3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = SubTotal();
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price + ", Quantity:" + Quantity + ", Subtotal: $" + Price.ToString("F2");
        }
    }

}
