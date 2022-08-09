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
    /// Interaction logic for SuplierForm.xaml
    /// </summary>
    public partial class SuplierForm : Window
    {
        Admin admin = new Admin();
        internal List<Suplier> sup = new List<Suplier>();
        Suplier s = null;
        public SuplierForm()
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
            InsertProduct i = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            i.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SuplierForm s = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            s = new Suplier();
            s.Name = textSublier .Text;
            s.Phone = int.Parse(textPhone .Text);
            s.ID = int.Parse(textID .Text);
            s.Category = textSubCategory.Text;
            sup.Add(s);
            // ParentStors.Supliers.Add(s);
            admin.addsublier(sup);
            dataGrid1.ItemsSource = null;
            dataGrid1.ItemsSource = sup;
            comboboxSuplier.Items.Add(s.Name);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ParentStors.Supliers.RemoveAt(comboboxSuplier.SelectedIndex);
            comboboxSuplier.Items.Remove(comboboxSuplier.SelectedItem);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            customerForm c = new customerForm();
            this.Visibility = Visibility.Hidden;
            c.Show();
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
