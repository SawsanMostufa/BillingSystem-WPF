using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashoinStore
{
    internal class Admin
    {

        public string username { get; set; }
        public string password { get; set; }
        public Admin() { }

        public void addstore(List<Store> store)
        {
            ParentStors.stores = store;



        }
        public void addsublier(List<Suplier> sup)
        {
            ParentStors.Supliers = sup;



        }

        public void addcustomer(List<Customers> cust)
        {
            ParentStors.Customers = cust;
        }

        public void adeletestore(List<Store> store)
        {
            ParentStors.stores = store;

        }


        public void addproducts(Product pro, Store str)
        {

            foreach (Store s in ParentStors.stores)
            {

                if (s.Name == str.Name)
                {
                    Store.products.Add(pro);
                }
            }


        }

        public Store showproductinstore<Store>(Store myst)
        {



            return myst;

        }
    }
}
