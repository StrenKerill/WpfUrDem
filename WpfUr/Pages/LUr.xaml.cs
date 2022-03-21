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
using ClassLibraryFun;

namespace WpfUr.Pages
{
    /// <summary>
    /// Логика взаимодействия для LUr.xaml
    /// </summary>
    public partial class LUr : Page
    {
        public LUr()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            var b = Window.GetWindow(this) as MainWindow;
            b.OwnerFrame.Navigate(new Pages.OwnerPage());
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            double a, b, c, x1;
            double.TryParse(this.a.Text, out a);
            double.TryParse(this.b.Text, out b);
            double.TryParse(this.c.Text, out c);
            string message;
            string res = "";
            Ur.LnUr(a, b, c, out x1, out message);
            if (!double.IsNaN(x1)) res += $"x={x1}\n";
            if (!string.IsNullOrEmpty(message)) res += message;
            this.result.Text = res;
        }
    }
}
