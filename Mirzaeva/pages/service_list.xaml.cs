using Mirzaeva.AppData;
using Mirzaeva.Model;
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

namespace Mirzaeva.pages
{
    /// <summary>
    /// Логика взаимодействия для service_list.xaml
    /// </summary>
    public partial class service_list : Page
    {
        public service_list()
        {
            InitializeComponent();
            service_view_list.ItemsSource = ConnectDb.get_context().Service.ToList();
        }

        private void service_view_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigation_helper.selected_service = service_view_list.SelectedItem as Service;
        }
    }
}
