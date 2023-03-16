using Microsoft.EntityFrameworkCore;
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

namespace WpfApp10.Pages
{
    /// <summary>
    /// Interaction logic for LVAdm.xaml
    /// </summary>
    public partial class LVAdm : Page
    {
        public LVAdm()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            LV_Adm.ItemsSource = ISPr2243_ZobninDS_OSNOVAContext.Init().Services.ToList();
        }

            private void DelService(object sender, RoutedEventArgs e)
        {
            Service DelService = (sender as Button).DataContext as Service;
            if (MessageBox.Show("Вы дейсвительно хотите удалить запись", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ISPr2243_ZobninDS_OSNOVAContext.Init().Remove<Service>(DelService);

                ISPr2243_ZobninDS_OSNOVAContext.Init().SaveChanges();
            }
            Update();
        }

        private void EditService(object sender, RoutedEventArgs e)
        {
            Service service = (sender as Button).DataContext as Service;
            AddPage add = new AddPage(service);
            NavigationService.Navigate(new AddPage(service));
            Update();
        }

        private void AddService(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage(new Service()));
            Update();
        }
    }
}
