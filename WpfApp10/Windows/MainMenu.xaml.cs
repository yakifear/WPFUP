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
using WpfApp10.Pages;

namespace WpfApp10.Windows
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //выход из аккаунта
        private void Leave(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Hide();
        }
        //вывод данных через кнопку "LVUserBT" в фрейм с названием "LVUser"
        private void LVUserBT(object sender, RoutedEventArgs e)
        {
            FrameUser.Navigate(new LVUser());
        }
    }
}
