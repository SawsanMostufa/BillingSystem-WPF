using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashoinStore
{
    internal class ParentStors
    {

        public double budget { get; set; }
        public ParentStors() { }


        public static List<Customers> Customers = new List<Customers>();
        public static List<Store> stores = new List<Store>();
        public static List<Suplier> Supliers = new List<Suplier>();







        // int counter = 0;
        // public new void Add(Product Pro1) 
        // {

        //     base.Add(Pro1);
        //     counter++;

        // }
        //public new void Remove(Product pro1)
        // {
        //     base.Remove(pro1);
        //     counter--;
        // }



        // public IReadOnlyCollection<Clothe> clothess
        // {
        //     get
        //     {
        //         List<Clothe> closelist = new List<Clothe>();
        //         foreach(Product pro1 in this)
        //         {
        //             if(pro1 is Clothe)
        //             {
        //                 closelist.Add((Clothe)pro1);

        //             }
        //         }
        //         return closelist;
        //     }
        // }

        // public IReadOnlyCollection<Bag> bages
        // {
        //     get
        //     {
        //         List<Bag> baglist = new List<Bag>();
        //         foreach (Product pro1 in this)
        //         {
        //             if (pro1 is Bag)
        //             {
        //                 baglist.Add((Bag)pro1);
        //             }
        //         }
        //         return baglist;
        //     }
        // }

        // public IReadOnlyCollection<Shoes> shoeses
        // {
        //     get
        //     {
        //         List<Shoes> shoselist = new List<Shoes>();
        //         foreach (Product pro1 in this)
        //         {
        //             if (pro1 is Shoes)
        //             {
        //                 shoselist.Add((Shoes)pro1);
        //             }
        //         }
        //         return shoselist;
        //     }
        // }
    }
}
