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
    /// Interaction logic for customerForm.xaml
    /// </summary>
    public partial class customerForm : Window
    {
        Customers c = null;
        Admin admin = new Admin();
        internal List<Customers> cust = new List<Customers>();
        public customerForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InsertProduct s = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            s.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SuplierForm s = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            customerForm s = new customerForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            c = new Customers();
            c.Name = textCustomer .Text;
            c.phone = int.Parse(textPhone.Text);
            c.ID = int.Parse(textID.Text);
            cust.Add(c);
            admin.addcustomer(cust);
            dataGrid1.ItemsSource = null;
            dataGrid1.ItemsSource = cust;
            comboboxCustomer.Items.Add(c.Name);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ParentStors.Customers.RemoveAt(comboboxCustomer.SelectedIndex);
            comboboxCustomer.Items.Remove(comboboxCustomer.SelectedItem);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SellBill s = new SellBill();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Report s = new Report();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            contAdminfrm m = new contAdminfrm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
