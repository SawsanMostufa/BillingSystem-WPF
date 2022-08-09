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
    /// Interaction logic for welcome.xaml
    /// </summary>
    public partial class welcome : Window
    {
        public welcome()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prograss s = new prograss();
            this.Visibility = Visibility.Hidden;
            s.Show();

        }
    }
}
