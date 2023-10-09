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


            products[0].productid = 101;
            products[0].productname = "Shirt";
            products[0].price = 100;
            products[0].unitofMeasurement = "Large";
            products[0].quantity = 5;

            products[1].productid = 102;
            products[1].productname = "jeans";
            products[1].price = 600;
            products[1].unitofMeasurement = "Small";
            products[1].quantity = 2;


            products[2].productid = 103;
            products[2].productname = "Milk";
            products[2].price = 100;
            products[2].unitofMeasurement = "litre";
            products[2].quantity = 5;

            products[3].productid = 104;
            products[3].productname = "Mobile Phone";
            products[3].price = 50000;
            products[3].unitofMeasurement = "KG";
            products[3].quantity = 1;

            products[4].productid = 105;
            products[4].productname = "laptop";
            products[4].price = 100000;
            products[4].unitofMeasurement = "KG";
            products[4].quantity = 1;

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
