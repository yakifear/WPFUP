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
using WpfApp10.Windows;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //scaffold-dbContext "" Pomelo.EntityFrameworkCore.MySql
            //Server=cfif31.ru; Port=3306; UserID=ISPr22-43_ZobninDS ;Password=ISPr22-43_ZobninDS; Database=ISPr22-43_ZobninDS_OSNOVA;
        }

        private void Vhod(object sender, RoutedEventArgs e)
        {
                Client user = ISPr2243_ZobninDS_OSNOVAContext.Init().Clients.FirstOrDefault(p => p.Email == LoginTB.Text &&
                (p.Phone == PassTB.Text) || (p.Phone == PassPB.Password)); // || (p.Phone == PassPB.Password) не обязательно, только если добавлять функцию скрытия пароля

            if (user != null)
                {
                    if (user.GenderCode == "ж")
                    {
                        MainMenu wind = new MainMenu(); //если нужно без деления вывести, то просто выписать то, что в скобках if прописанно, без самого if
                        wind.Show();
                        Hide();
                    }
                    if (user.GenderCode == "м") //можно прописать просто else без скобок и тогда просто выведется окно во всех иных случаях, отличающихся от предыдущих if
                    {
                        MainMenuAdm wind = new MainMenuAdm();
                        wind.Show();
                        Hide();
                    }
                }
            else
            {
                MessageBox.Show("Данные указаны неверно или имеются незаполненные поля!");
            }
        }
        //всё внизу для галочки "показать пароль"
        private void VisPass(object sender, RoutedEventArgs e)
        {
            //галочка стоит
            PassTB.Text = PassPB.Password;
            PassTB.Visibility = Visibility.Visible;
            PassPB.Visibility = Visibility.Hidden;
        }
        private void NoVisPass(object sender, RoutedEventArgs e)
        {
            //галочка не стоит
            PassPB.Password = PassTB.Text;
            PassTB.Visibility = Visibility.Hidden;
            PassPB.Visibility = Visibility.Visible;
        }
    }
}
