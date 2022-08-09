using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FashoinStore
{
    /// <summary>
    /// Interaction logic for InsertProduct.xaml
    /// </summary>
    public partial class InsertProduct : Window
    {
        Admin admin = new Admin();
        public InsertProduct()
        {
            InitializeComponent();
            for (int i = 0; i < ParentStors.stores.Count(); i++)
            {
                comboxstore.Items.Add(ParentStors.stores[i].Name);


            }
            List<Store> stores = new List<Store>();
            MainWindow addstorefrm = new MainWindow();
            foreach (var s in addstorefrm.adminss)
            {
                stores.Add(s);
            }

            foreach (var s in stores)
            {
                comboxstore.Items.Add(s);


            }



            for (int i = 0; i < ParentStors.Supliers.Count(); i++)
            {
                comboxsublier.Items.Add(ParentStors.Supliers[i].Name);
            }
            List<Suplier> suplier = new List<Suplier>();
            SuplierForm addsupliersfrm = new SuplierForm();
            foreach (var supp in addsupliersfrm.sup)
            {
                suplier.Add(supp);
            }

            foreach (var supp in suplier)
            {
                comboxsublier.Items.Add(supp);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InsertProduct p = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            p.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Product p1 = new Product();
            p1.name =  textproduct .Text;
            p1.Category = textCategory .Text;
            p1.price = int.Parse(textprice.Text);
            p1.material = textmaterial .Text;
            p1.size = textsize .Text;
            p1.color = textcolor .Text;
            p1.date = DateTime.Now;
            p1.supliers = (string) comboxsublier .SelectedItem;
            // p1.quentity = int.Parse(textBoxquentity.Text);
            foreach (Product pooo in Store.products)
            {
                if (pooo.name == textproduct.Text)
                {
                    pooo.quentity += int.Parse(textquantity.Text);

                    p1.quentity = pooo.quentity;

                }
                else
                {
                    p1.quentity = int.Parse(textquantity.Text);
                }
                //  mynewproduct.custpmers =(string)comboBoxcustomer.SelectedItem;

            }
            string combo = comboxstore.Text;
            Store s = new Store();

            if (combo == p1.Category)
            {
                s.Name = combo;
            }
            admin.addproducts(p1, s);
            this.dataGrid1.ItemsSource = null;
            this.dataGrid1.ItemsSource = Store.products;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SuplierForm s = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            customerForm c = new customerForm();
            this.Visibility = Visibility.Hidden;
            c.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SellBill s = new SellBill();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Report s = new Report();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            contAdminfrm m = new contAdminfrm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
