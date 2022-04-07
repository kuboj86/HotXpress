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

namespace HotXpress
{
    /// <summary>
    /// Interaction logic for Home_Screen.xaml
    /// </summary>
    public partial class Home_Screen : Page
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void nav_ToMenu(object sender, RoutedEventArgs e)
        {
            HomeScreenFrame.NavigationService.Navigate(new Menu_Page());
        }
    }
}
