using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashoinStore
{
    internal class Store
    {

        public static List<Product> products = new List<Product>();
        public static List<Product> listofbill = new List<Product>();
        public string Name { get; set; }
        //public double income { get; set; }
        //public double outcome { get; set; }
        public static List<Product> GetProducts(string category)
        {
            List<Product> tempProduct = new List<Product>();
            foreach (Product p in products)
            {
                if (p.Category == category)
                    tempProduct.Add(p);
            }
            return tempProduct;
            // return products.Select(s => s.Category == category).ToList();


        }

        public static List<Product> GetProductsforcustomer(string customer)
        {
            List<Product> tempProduct = new List<Product>();
            foreach (Product p in Store.listofbill)
            {
                if (p != null)
                {
                    if (p.custpmers == customer)
                        tempProduct.Add(p);
                }
            }
            return tempProduct;
            // return products.Select(s => s.Category == category).ToList();


        }

        public static List<Product> GetProductsforsuplier(string sup)
        {
            List<Product> tempProduct = new List<Product>();
            foreach (Product p in products)
            {
                if (p != null)
                {
                    if (p.supliers == sup)
                        tempProduct.Add(p);
                }
            }
            return tempProduct;
            // return products.Select(s => s.Category == category).ToList();


        }

        public void Add(Product p1, ParentStors parentp)
        {
            foreach (Store s in ParentStors.stores)
            {
                if (p1.Category == s.Name)
                    products.Add(p1);

            }
        }
    }
}
