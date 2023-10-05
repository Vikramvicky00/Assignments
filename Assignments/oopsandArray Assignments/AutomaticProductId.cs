using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.oopsandArray_Assignments
{
    internal class AutomaticProductId
    {
        static int _pid=100;
        private string _pname;
        private int? _price;
        private string _unitofMeasurement;
        private int? _qty;

        public AutomaticProductId()
        {
            _pid += 1;
        }

        public int productId {
             get { return _pid; }
            }

            public int? price
            {
                get { return _price; }
                set { _price = value; }
            }

            public string unitofMeasurement
            {
                get { return _unitofMeasurement; }
                set { _unitofMeasurement = value; }
            }

            public int? quantity
            {
                get { return _qty; }
                set { _qty = value; }
            }

            public string productname
            {
                get { return _pname; }
                set { _pname = value; }
            }
        static void Main(string[] args)
        {
            AutomaticProductId automaticProductId1 = new AutomaticProductId();
            automaticProductId1.price = 100;
            automaticProductId1.quantity = 2;
            automaticProductId1.unitofMeasurement = "litre";
            automaticProductId1.productname = "Milk";

            Console.WriteLine();
            Console.WriteLine(automaticProductId1.productId);
            Console.WriteLine(automaticProductId1.productname);
            Console.WriteLine(automaticProductId1.price);
            Console.WriteLine(automaticProductId1.unitofMeasurement);
            Console.WriteLine(automaticProductId1.quantity);

            AutomaticProductId automaticProductId2 = new AutomaticProductId();
            automaticProductId2.price = 100;
            automaticProductId2.quantity = 2;
            automaticProductId2.unitofMeasurement = "Small";
            automaticProductId2.productname = "Shirt";
            Console.WriteLine();
            Console.WriteLine(automaticProductId2.productId);
            Console.WriteLine(automaticProductId2.productname);
            Console.WriteLine(automaticProductId2.price);
            Console.WriteLine(automaticProductId2.unitofMeasurement);
            Console.WriteLine(automaticProductId2.quantity);
            Console.ReadLine();


        }
    }
}
