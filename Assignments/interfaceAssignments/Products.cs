using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.interfaceAssignments
{
    public class Products : Customer 
    {
        static int prodId=100;

        public Products()
        {
           prodId +=1;
        }

        public int ProdId
        {
            get { return prodId; }
        }
        private string prodName;
        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; }
        }

        private int qty;

        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

      
    }
}
