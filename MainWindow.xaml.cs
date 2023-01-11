using Microsoft.VisualBasic;
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
using System.Resources;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using System.Reflection;
using System.Globalization;
using System.Threading;
using reg_resource.properties;
using System.Runtime;

namespace reg_resource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
            InitializeComponent();
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;
            int age =Convert.ToInt32( txtage.Text);
            string mail = txtemail.Text;
            string password = pswd.Password;
            string cpassword = cpswd.Password;

            properties.Settings1 settings = new properties.Settings1();
            settings.username = txtname.Text;
            settings.password = pswd.Password.ToString();
            settings.Save();

            //if (txtname.Text == "")
            //{
            //    lblname.Content = "*PLEASE ENTER THE NAME";
            //    //  lblname.Content= x: Static lang: Resource1.lname;
            //}

            //int age = Convert.ToInt32(txtage.Text.ToString());
            //if (age < 18)
            //{
            //    lblage.Content = "*AGE SHOULD BE ABOVE 18";
            //    txtage.Clear();
            //}

            //String email = txtemail.Text.ToString();
            ////char[] chars1 = email.ToCharArray();
            //////int elength = chars1.Length;
            ////for (int i = 0; i < chars1.Length; i++)
            ////{
            ////    if (chars1[i] != '@' || chars1[i] != '.')

            ////    //{
            ////    //   txtemail.Text.ToString();
            ////    // }
            ////    // else
            ////    {
            ////        lblemail.Content = "*INVALID EMAIL ID";
            ////        txtemail.Clear();

            ////    }
            ////}

            //string password = txtpswd.Text.ToString();
            //char[] chars = password.ToCharArray();
            //int pswdlength = chars.Length;

            //if (pswdlength < 8)
            //{
            //    lblpswd.Content = "*PASSWORD SHOULD HAVE 8 CHARACTERS";
            //    txtpswd.Clear();
            //}

            //if (txtpswd.Text != txtcpswd.Text)
            //{
            //    lblcpswd.Content = "*PASSWORD ARE NOT MATCHED";
            //    txtcpswd.Clear();
            //}

            ResourceManager rm = new ResourceManager("reg_resource.properties.language.Resource1", Assembly.GetExecutingAssembly());

            if ((txtname.Text != "") && (txtage.Text != "") && (txtemail.Text != "") && (pswd.Password != "") && (cpswd.Password != ""))
            {

                MessageBox.Show(rm.GetString("text1") , "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
                // MessageBox.Show("REGISTERED SUCCESSFULLY","REGISTER" ,MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(rm.GetString("text2"), "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //MessageBox.Show("ERROR!!!!!ENTER ALL DETAILS","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // string language = "en-US";
            // if(rbtam.IsChecked==true)
            // {
            //     language = rbtam.Tag.ToString();
            // }
            //else if (rbtel.IsChecked == true)
            // {
            //     language = rbtel.Tag.ToString();
            // }
            //else if (rbhin.IsChecked == true)
            // {
            //     language = rbhin.Tag.ToString();
            // }
            // else if (rbjap.IsChecked == true)
            // {
            //     language = rbjap.Tag.ToString();
            // }
            // properties.Settings1 settings = new properties.Settings1();
            // settings.Language = language;
            // settings.Save();

            // CultureInfo ci = new CultureInfo(settings.Language);
            // Thread.CurrentThread.CurrentCulture = ci;
            // Thread.CurrentThread.CurrentUICulture = ci;

            //txtname.Clear();
            //txtage.Clear();
            //txtemail.Clear();
            //pswd.Clear();
            //cpswd.Clear();

            //lblname.Content = "";
            //lblage.Content = "";
            //lblemail.Content = "";
            //lblpswd.Content = "";
            //lblcpswd.Content = "";
            ////lblage.Visibility = Visibility.Visible;

            login pg = new login();
            pg.Show();
            this.Close();

        }
    }
}
