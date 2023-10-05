using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.oopsandArray_Assignments
{
    internal class ObjectProducts
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.productid = 001;
            p1.productname = "Shirt";
            p1.price = 100;
            p1.unitofMeasurement = "Large";
            p1.quantity = 5;

            Product p2 = new Product();
            p2.productid = 002;
            p2.productname = "jeans";
            p2.price = 600;
            p2.unitofMeasurement = "Small";
            p2.quantity = 2;

            Product p3 = new Product();
            p3.productid = 003;
            p3.productname = "Milk";
            p3.price = 100;
            p3.unitofMeasurement = "litre";
            p3.quantity = 5;

            Product p4 = new Product();
            p4.productid = 004;
            p4.productname = "Mobile Phone";
            p4.price = 50000;
            p4.unitofMeasurement = "KG";
            p4.quantity = 1;

            Product p5 = new Product();
            p5.productid = 005;
            p5.productname = "laptop";
            p5.price = 100000;
            p5.unitofMeasurement = "KG";
            p5.quantity = 1;

            Console.WriteLine("Product Details :");
            Console.WriteLine($" ProductId:{p1.productid}\n ProductName:{p1.productname}\n Price:{p1.price}\n UnitoFMeasurements:{p1.unitofMeasurement}\n Quantity:{p1.quantity}");
            Console.ReadLine();



        }
    }
}
