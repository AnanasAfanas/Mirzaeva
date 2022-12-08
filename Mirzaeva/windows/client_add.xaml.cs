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
using System.Windows.Shapes;

namespace Mirzaeva.windows
{
    /// <summary>
    /// Логика взаимодействия для client_add.xaml
    /// </summary>
    public partial class client_add : Window
    {
        Clients cl = new Clients();
        public client_add()
        {
            InitializeComponent();
        }

        private void add_new_client_btn_Click(object sender, RoutedEventArgs e)
        {
            cl.client_name = client_surname_tb.Text;
            cl.client_phone = client_phone_tb.Text;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                clien11t_photo_tb.Text = filename;
            }


            ConnectDb.get_context().Clients.Add(cl);
            ConnectDb.get_context().SaveChanges();

            this.Close();
        }
    }
}
