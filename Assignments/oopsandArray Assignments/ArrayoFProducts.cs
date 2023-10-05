using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.oopsandArray_Assignments
{
    internal class ArrayoFProducts
    {
        static void Main(string[] args)
        {
            Product[] products= new Product[5];

            products[0] = new Product
            {
                productid = 101,
                productname = "Shirt",
                price = 100,
                unitofMeasurement = "Large",
                quantity = 5
            };


            products[1] = new Product
            {
                productid = 102,
                productname = "jeans",
                price = 600,
                unitofMeasurement = "Small",
                quantity = 2
            };

            products[2] = new Product
            {
                productid = 103,
                productname = "Milk",
                price = 100,
                unitofMeasurement = "litre",
                quantity = 5
            };

            products[3] = new Product
            {
                productid = 104,
                productname = "Mobile Phone",
                price = 50000,
                unitofMeasurement = "KG",
                quantity = 1
            };

            products[4] = new Product
            {
                productid = 105,
                productname = "laptop",
                price = 100000,
                unitofMeasurement = "KG",
                quantity = 1
            };

            foreach (var item in products)
            {
                Console.WriteLine(item.productid);
                Console.WriteLine(item.productname);
                Console.WriteLine(item.price);
                Console.WriteLine(item.unitofMeasurement);
                Console.WriteLine(item.quantity);
            }
            Console.ReadLine();

        }
    }
}
