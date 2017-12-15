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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        

        public Register()
        {
            InitializeComponent();
            lb5.Visibility = Visibility.Hidden;
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zak\Desktop\PizzaWPF\Pizza_Project\Pizza_Project\bin\Debug\DB_UserREG.mdb");

        private void lbExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void sign_up_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pass.Password == Cpass.Password)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO REG_user (NAME,LASTNAME,PHONE,SEX,EMAIL,PASS,CPASS,BIRTH) VALUES ('" + name.Text + "','" + Lastname.Text + "','" + MobileNumber.Text + "','" + Sex.Text + "','" + email.Text + "','" + pass.Password + "','" + Cpass.Password + "','" + Databirth.SelectedDate.Value.ToString() + "')";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย","",
                MessageBoxButton.OK);
                con.Close();
            }
            else
            {
                lb5.Visibility = Visibility.Visible;
            }
}
    }
}
