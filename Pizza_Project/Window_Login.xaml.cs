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
using System.Data.SqlClient;
using System.Data;
using Finisar.SQLite;
using System.Data.OleDb;

namespace Pizza_Project
{
    /// <summary>
    /// Interaction logic for Window_Login.xaml
    /// </summary>
    public partial class Window_Login : Window
    {
        public Window_Login()
        {
            InitializeComponent();
        }
        

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close(); 
        }

        private void _Sing_up_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zak\Desktop\PizzaWPF\Pizza_Project\Pizza_Project\bin\Debug\DB_UserREG.mdb");
                OleDbDataAdapter Oda = new OleDbDataAdapter("Select * from REG_user Where EMAIL= '" + TEXT_Uername.Text + "' and PASS=" + TEXT_Password.Password, con);
                DataTable dt = new DataTable();
                Oda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    MainWindow main = new MainWindow();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("รหัสผ่าน หรือ อีเมลล์ ของคุณไม่ถูกต้อง", "Some title",
                    MessageBoxButton.OK);
                }
            }
            catch
            {
               MessageBox.Show("กรุณากรอกอีเมลล์ และ รหัสผ่าน ของคุณให้ถูกต้อง","",
                MessageBoxButton.OK, MessageBoxImage.Question);
            }
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Zak\Desktop\PizzaWPF\Pizza_Project\Pizza_Project\Local_Data_Login.mdf; Integrated Security = True");
            //    SqlDataAdapter sda = new SqlDataAdapter("Select Role from Login Where Username= '" + TEXT_Uername.Text + "' and Password='" + TEXT_Password.Password + "'  ", con);
            //    DataTable dt = new System.Data.DataTable();
            //    sda.Fill(dt);
            //    if (dt.Rows.Count == 1)
            //    {
            //        this.Hide();
            //        MainWindow main = new MainWindow();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Some text", "Some title",
            //    MessageBoxButton.OK);
            //}
        }

            private void watermarkedText_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText.Visibility = System.Windows.Visibility.Collapsed;
            TEXT_Uername.Visibility = System.Windows.Visibility.Visible;
            TEXT_Uername.Focus();
        }

        private void TEXT_Uername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TEXT_Uername.Text))
            {
                TEXT_Uername.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText.Visibility = System.Windows.Visibility.Visible;
            }
        }


        private void watermarkedTextPass_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedTextPass.Visibility = System.Windows.Visibility.Collapsed;
            TEXT_Password.Visibility = System.Windows.Visibility.Visible;
            TEXT_Password.Focus();
        }

        private void TEXT_Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TEXT_Password.ToString()))
            {
                TEXT_Password.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTextPass.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Click_signUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
    }
}
