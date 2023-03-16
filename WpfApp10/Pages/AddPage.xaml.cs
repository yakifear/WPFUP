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
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Service service;
        public AddPage(Service service)
        {
            this.service = service;
            DataContext = service;
            InitializeComponent();
        }

        private void AddServ(object sender, RoutedEventArgs e)
        {
            if (service.Id == 0)
            {
                ISPr2243_ZobninDS_OSNOVAContext.Init().Services.Add(service);
            }
            ISPr2243_ZobninDS_OSNOVAContext.Init().SaveChanges();
            NavigationService.Navigate(new LVAdm());
        }
    }
}
