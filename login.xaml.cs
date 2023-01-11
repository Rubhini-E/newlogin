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
using System.Xml.Linq;

namespace reg_resource
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtuser.Text;
            string password = upassword.Password;

            properties.Settings1 settings = new properties.Settings1();
            if((username == settings.username) && (password == settings.password))
            {
                update up = new update();
                up.lblcontent.Content = $"HI WELCOME BACK {txtuser.Text}";
                up.Show();
                this.Close();
            }
            else
            {
                ResourceManager rm = new ResourceManager("reg_resource.properties.language.Resource1", Assembly.GetExecutingAssembly());
                MessageBox.Show(rm.GetString("text3"), "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            reg.Show();
            this.Close();
                            
         }
    }
}
