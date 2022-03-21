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

namespace WpfUr.Pages
{
    /// <summary>
    /// Логика взаимодействия для OwnerPage.xaml
    /// </summary>
    public partial class OwnerPage : Page
    {
        public OwnerPage()
        {
            InitializeComponent();
        }

        private void btnKvUr(object sender, RoutedEventArgs e)
        {
            var ku = Window.GetWindow(this) as MainWindow;
            ku.OwnerFrame.Navigate(new Pages.KUr());
        }

        private void btnLUr(object sender, RoutedEventArgs e)
        {
            var lu = Window.GetWindow(this) as MainWindow;
            lu.OwnerFrame.Navigate(new Pages.LUr());
        }
    }
}
