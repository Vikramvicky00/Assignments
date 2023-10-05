using System;

namespace Assignments.oopsandArray_Assignments
{
    internal class Product
    {
        private int? _pid;
        private string _pname;
        private int? _price;
        private string _unitofMeasurement;
        private int? _qty;


        public int? productid
        {
            get { return _pid; }
            set { _pid = value; }
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
            get { return _qty;}
            set { _qty = value;}
        }
         
        public string productname
        {
            get { return _pname;}
            set {_pname = value;}
        }
    }
}
