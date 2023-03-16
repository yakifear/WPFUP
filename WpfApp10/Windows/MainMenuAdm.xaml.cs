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
    /// Interaction logic for MainMenuAdm.xaml
    /// </summary>
    public partial class MainMenuAdm : Window
    {
        public MainMenuAdm()
        {
            InitializeComponent();
        }
        //выход из аккаунта
        private void LeaveAdm(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Hide();
        }
        //вывод данныъ через кнопку "LVAdmBT" в фрейм с названием "LVAdm"
        private void LVAdmBT(object sender, RoutedEventArgs e)
        {
            FrameAdm.Navigate(new LVAdm());
        }
    }
}
