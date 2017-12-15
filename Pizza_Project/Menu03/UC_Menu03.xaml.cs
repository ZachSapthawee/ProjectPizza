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

namespace Pizza_Project
{
    /// <summary>
    /// Interaction logic for UC_Menu03.xaml
    /// </summary>
    public partial class UC_Menu03 : UserControl
    {
        int i = 0;
        string[] Num = new string[1500];
        string[] Me_nu = new string[1500];
        string[] Price = new string[1500];
        public UC_Menu03()
        {
            InitializeComponent();
        }

        private void Budget1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Num[i] = (i + 1).ToString();
            Me_nu[i] = "ชุดปาร์ตี้ ปีใหม่";
            Price[i] = "449";
        }
    }
}
