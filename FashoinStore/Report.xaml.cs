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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
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
                comboxsup.Items.Add(ParentStors.Supliers[i].Name);
            }
            //List<Suplier> suplier = new List<Suplier>();
            //SuplierForm addsupliersfrm = new SuplierForm();
            //foreach (var supp in addsupliersfrm.sup)
            //{
            //    suplier.Add(supp);
            //}

            //foreach (var supp in suplier)
            //{
            //    comboBox2.Items.Add(supp);
            //}

            //*******************************************************************

            //for (int i = 0; i < ParentStors.Customers.Count(); i++)
            //{
            //    comboxcust.Items.Add(ParentStors.Customers[i].Name);
            //}
            //List<Customers> customer = new List<Customers>();
            //customerForm custoerform = new customerForm();
            //foreach (var cus in custoerform.cust)
            //{
            //    customer.Add(cus);
            //}

            //foreach (var s in customer)
            //{
            //    comboBox3.Items.Add(s);
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string test = comboxsup.Text.ToString();
            dataGrid2.ItemsSource = null;
            dataGrid2.ItemsSource = Store.GetProductsforcustomer(test);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string test = comboxstore.Text.ToString();
            dataGrid1.ItemsSource = Store.GetProducts(test);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //string test = comboxcust.Text.ToString();
            //dataGrid3.ItemsSource = null;
            //dataGrid3.ItemsSource = Store.GetProductsforsuplier(test);
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            Report r = new Report();
            this.Visibility = Visibility.Hidden;
            r.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SellBill m = new SellBill();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SuplierForm m = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            customerForm m = new customerForm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InsertProduct m = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            contAdminfrm m = new contAdminfrm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
