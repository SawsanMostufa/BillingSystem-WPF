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
    /// Interaction logic for SellBill.xaml
    /// </summary>
    public partial class SellBill : Window
    {
        ParentStors p = new ParentStors();

        Admin admin = new Admin();
        Product mypoduct = null;
        List<Product> listofchoesedroduct = new List<Product>();
        //  List<Product> listofbill = new List<Product>();
        double totalPrice = 0;
        public SellBill()
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


            //*************************************************

            for (int i = 0; i < ParentStors.Customers.Count(); i++)
            {
                comboxCust.Items.Add(ParentStors.Customers[i].Name);
            }
            List<Customers> customer = new List<Customers>();
            customerForm custoerform = new customerForm();
            foreach (var cus in custoerform.cust)
            {
                customer.Add(cus);
            }

            foreach (var s in customer)
            {
                comboxCust.Items.Add(s);
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ComboBox c = comboBox1;

            string test = comboxstore.Text.ToString();
            dataGrid1.ItemsSource = Store.GetProducts(test);
            //foreach (Store s in ParentStors.stores)
            //{   if (s.Name == test)
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           
        }

        private void StoreBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void ReportBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportBTN_Click_1(object sender, RoutedEventArgs e)
        {
            Report m = new Report();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
        private bool IsNumber(string text)
        {
            int result;
            return int.TryParse(text, out result);

        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (IsNumber(e.Text) == false)
            {
                e.Handled = true;
            }


        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StoreListbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            contAdminfrm m = new contAdminfrm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
