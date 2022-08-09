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
    /// Interaction logic for AdminLoginForm.xaml
    /// </summary>
    public partial class AdminLoginForm : Window
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string user, pass;
            user = usernamtxt.Text;
            pass = passwordtxt.Text;
            if (user != null && pass != null)
            {
                if (user == "Admin" || user == "admin" && pass == "Admin" || pass == "admin")
                {
                    contAdminfrm form5 = new contAdminfrm();
                    form5.Show();
                    //this.Close();
                }
                else
                {
                    errorlbl.Visibility = Visibility.Visible;
                    errorlbl.Content = "Wrong User_Name Or Password .. !";
                }
            }
            else
            {
                errorlbl.Visibility = Visibility.Visible;
                errorlbl.Content = "Please Enter User_Name and Password ... !";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            welcome m = new welcome();
            this.Visibility = Visibility.Hidden;
            m.Show();
        }
    }
}
