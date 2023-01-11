using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Resources;

namespace reg_resource
{ 
    /// <summary>
    /// Interaction logic for update.xaml
    /// </summary>
    public partial class update : Window
    {
        public update()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;
            int age = Convert.ToInt32(txtage.Text);
            string mail = txtemail.Text;
            string password = pswd.Password;
            string cpassword = cpswd.Password;

            properties.Settings1 settings = new properties.Settings1();
            settings.username = txtname.Text;
            settings.password = pswd.Password.ToString();
            settings.Save();


            ResourceManager rm = new ResourceManager("reg_resource.properties.language.Resource1", Assembly.GetExecutingAssembly());

            if ((txtname.Text != "") && (txtage.Text != "") && (txtemail.Text != "") && (pswd.Password != "") && (cpswd.Password != ""))
            {

                MessageBox.Show(rm.GetString("text5"), "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
                // MessageBox.Show("REGISTERED SUCCESSFULLY","REGISTER" ,MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login pg = new login();
            pg.Show();
            this.Close();
        }
    }
}
