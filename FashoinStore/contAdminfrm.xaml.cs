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
    /// Interaction logic for contAdminfrm.xaml
    /// </summary>
    public partial class contAdminfrm : Window
    {
        public contAdminfrm()
        {
            InitializeComponent();
        }

        private void storebtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customerForm c = new customerForm();
            this.Visibility = Visibility.Hidden;
            c.Show();
        }

        private void SellBillBtn_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SuplierForm s = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            Report r = new Report();
            this.Visibility = Visibility.Hidden;
            r.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InsertProduct i = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            i.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SellBill s = new SellBill();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void SellBillBtn_Click_1(object sender, RoutedEventArgs e)
        {
            SellBill s = new SellBill();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }
    }
}
