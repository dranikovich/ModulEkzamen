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

namespace ModulEkzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Classes.Base.BDD = new BookShop();
            Classes.MainFrame.MFrame = MFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Classes.MainFrame.MFrame.Navigate(new Windows.MainShop());

        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            Classes.MainFrame.MFrame.Navigate(new Windows.MainShop());
            ButtonEnter.Visibility = Visibility.Collapsed;
            ButtonRegister.Visibility = Visibility.Collapsed;
        }
    }
}
