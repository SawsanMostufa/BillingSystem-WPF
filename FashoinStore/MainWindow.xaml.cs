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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FashoinStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Admin admin = new Admin();
        Store s = null;
        internal List<Store> adminss = new List<Store>();
        internal List<Store> listdelete = new List<Store>();
        public MainWindow()
        {
            InitializeComponent();
            // StoreListbox.ItemsSource = ParentStors.stores;
            //foreach(Store ss in ParentStors.stores)
            //{
            //    comboboxStore.Items.Add(ss.Name);
            //}
            //comboboxStore.Items.Add(ParentStors.stores)
            //DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
         {
           // string sss = txtstore.Text;

            
           // comboStore.Items.Add(s.Name);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            s = new Store();
            s.Name = txtstore.Text;
            adminss.Add(s);
            admin.addstore(adminss);
            this.dataGrid1.ItemsSource = null;
            this.dataGrid1.ItemsSource = adminss;
           // comboStorebox.ItemsSource = adminss;
            comboStorebox.Items.Add(s.Name);
        }

        private void comboStore_Loaded(object sender, RoutedEventArgs e)
        {
            //var combo = sender as ComboBox;
            //combo.ItemsSource = ParentStors.stores;
            //foreach (var item in ParentStors.stores)
            //{
            //    comboboxStore.Items.Add(item.Name);
            //}

        }

        private void comboboxStore_Loaded(object sender, RoutedEventArgs e)
        {
            //foreach (var item in ParentStors.stores)
            //{
            //    comboboxStore.Items.Add(item.Name);
            //}

            //var com = sender as ComboBox;
            //com.ItemsSource = ParentStors.stores;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InsertProduct p = new InsertProduct();
            this.Visibility = Visibility.Hidden;
            p.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SuplierForm s = new SuplierForm();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ParentStors.stores.RemoveAt(comboStorebox.SelectedIndex);
            comboStorebox.Items.Remove(comboStorebox.SelectedItem);
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            customerForm c = new customerForm();
            this.Visibility = Visibility.Hidden;
            c.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SellBill s = new SellBill();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Report s = new Report();
            this.Visibility = Visibility.Hidden;
            s.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            contAdminfrm m = new contAdminfrm();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
