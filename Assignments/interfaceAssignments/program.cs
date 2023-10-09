using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.interfaceAssignments
{
    internal class program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Order order = new Order();
            customer.CustomerName = "Vikram";
            customer.City = "vizag";
            Console.WriteLine("Customerid");
            Console.WriteLine(customer.CustomerId);

            Products products = new Products();
            Console.WriteLine("productId");
            Console.WriteLine(products.ProdId);
           
            Console.WriteLine("orderId");
            Console.WriteLine(order.OrderID);

            Customer c = new Customer();
            Order o = new Order();
            Products p = new Products();

            Console.WriteLine("Customerid");
            Console.WriteLine(c.CustomerId);
            
            Console.WriteLine("productId");
            Console.WriteLine(p.ProdId);

            Console.WriteLine("orderId");
            Console.WriteLine(o.OrderID);

            Console.WriteLine("Enter Product Name:");
            products.ProdName = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            products.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            products.Quantity = Convert.ToInt32(Console.ReadLine());

            order.AddToCart(products.ProdId, products.ProdName, products.Quantity, products.Price);
            
            Products product = new Products();
            Console.WriteLine("Enter Product Name:");
            product.ProdName = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            product.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            product.Quantity = Convert.ToInt32(Console.ReadLine());



            
            
            order.AddToCart(product.ProdId, product.ProdName, product.Quantity, product.Price);


        }
    }
}
