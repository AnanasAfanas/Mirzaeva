using Mirzaeva.AppData;
using Mirzaeva.Model;
using Mirzaeva.pages;
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

namespace Mirzaeva.windows
{
    /// <summary>
    /// Логика взаимодействия для record_add.xaml
    /// </summary>
    public partial class record_add : Window
    {
        Records rec = new Records();
        public record_add()
        {
            InitializeComponent();
        }



        private void add_new_record_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rec.service_id = Convert.ToInt32(record_service_tb.Text);
                rec.barber_id = Convert.ToInt32(barber_record_tb.Text);
                rec.client_id = Convert.ToInt32(client_record_tb.Text);
                rec.reccord_date_and_time = Convert.ToDateTime(record_date_and_time_tb.Text);
                rec.record_coment = record_comment_tb.Text;

                ConnectDb.get_context().Records.Add(rec);
                ConnectDb.get_context().SaveChanges();

                navigation_helper.DBFrame.Navigate(new record_list());
                navigation_helper.selected_record = null;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }

        }
    }
}
