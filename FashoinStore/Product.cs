using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashoinStore
{
    internal class Product
    {
        public string name { get; set; }

        public int price { get; set; }

        public string size { get; set; }
        public string color { get; set; }

        public string material { get; set; }
        public string Category { get; set; }
        public string custpmers { get; set; }
        public string supliers { get; set; }
        public DateTime date { get; set; }
        //  Productsform profrm = new Productsform();
        // profrm.textbox
        public int quentity
        {
            get; set;
        }


        public override string ToString()
        {
            return name + " " + price + " " + size + " " + color + " " + material + " " + Category + " "
                + supliers + " " + custpmers + " " + date + " " + quentity;
        }
    }
}
