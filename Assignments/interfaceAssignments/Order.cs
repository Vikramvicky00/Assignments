using Assignments.oopsandArray_Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments.interfaceAssignments
{
    public class Order :Products, IOperations
    {
        static int orderId = 1000;
        private dynamic[] cart;
        private dynamic[][] items;
       public enum paymode
        {
            cash,
            upi,
            card
        }
        public Order()
        {
            orderId += 1;
        }
        public int OrderID
        {
            get { return orderId; }
        }

        private DateTime orderdate = DateTime.Today;

        public DateTime Orderdate
        {
            get { return orderdate; }
        }

        private paymode _paymode;

        public paymode GetPaymentMode
        {
            get { return _paymode; }
            set { _paymode = value; }
        }



        public void AddToCart(int prodid,string pname, int qty, int price)
        {
            //cart[0] = prodid;
            //cart[1] = pname;
            //cart[2] = qty;
            //cart[3] = price;
            
            Console.WriteLine("Item Added");
            Console.WriteLine(prodid);
            Console.WriteLine(pname);
            Console.WriteLine(qty);
            Console.WriteLine(price);
            Console.WriteLine("-----------");
        }



        public void PaymentGateway(int amt)
        {
            Console.WriteLine("Choose Payment Mode:");
            Console.WriteLine(" 1.Cash \n2.Upi \n3.Card");
            GetPaymentMode= (paymode)(Convert.ToInt32(Console.ReadLine())-1);
            Console.WriteLine("The Total Amount Rs. {0} Should be pay by {1}", amt, GetPaymentMode);
        }

        public void BuyNow()
        {
            int amt = Price * Quantity;
            PaymentGateway(amt);
            BookOrder();
        }

        public void BookOrder()
        {
            Console.WriteLine("Order Booked on {0}", Orderdate);
        }
    }
}
