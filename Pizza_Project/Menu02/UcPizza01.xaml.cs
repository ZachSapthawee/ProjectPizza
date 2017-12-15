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
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Pizza_Project.UserController
{
    /// <summary>
    /// Interaction logic for UcPizza01.xaml
    /// </summary>
    public partial class UcPizza01 : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zak\Desktop\PizzaWPF\Pizza_Project\Pizza_Project\bin\Debug\DB_UserREG.mdb");
        
        public UcPizza01()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

          
        }
        private void pizzaSize1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize1.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType1.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price1.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price1.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price1.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price1.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price1.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price1.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price1.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price1.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        private void pizzaType1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize1.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType1.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price1.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price1.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price1.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price1.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price1.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price1.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price1.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price1.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        //---------------------------------------------------------------------------------------------------------//
        private void pizzaType2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize2.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType2.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price2.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price2.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price2.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price2.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price2.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price2.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price2.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price2.Content = "609";
                }
            }
            catch
            {
                return;
            }

        }
        private void pizzaSize2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize2.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType2.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price2.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price2.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price2.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price2.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price2.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price2.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price2.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price2.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        //---------------------------------------------------------------------------------------------------------//
        private void pizzaType3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize3.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType3.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price3.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price3.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price3.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price3.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price3.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price3.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price3.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price3.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        private void pizzaSize3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize3.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType3.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price3.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price3.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price3.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price3.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price3.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price3.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price3.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price3.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        //---------------------------------------------------------------------------------------------------------//
        private void pizzaType4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize4.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType4.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price4.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price4.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price4.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price4.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price4.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price4.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price4.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price4.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        private void pizzaSize4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize4.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType4.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price4.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price4.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price4.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price4.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price4.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price4.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price4.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price4.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        //---------------------------------------------------------------------------------------------------------//
        private void pizzaType5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize5.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType5.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price5.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price5.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price5.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price5.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price5.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price5.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price5.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price5.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }
        private void pizzaSize5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBoxItem boxSize = (ComboBoxItem)pizzaSize5.SelectedItem;
                string size = boxSize.Content.ToString();
                ComboBoxItem boxType = (ComboBoxItem)pizzaType5.SelectedItem;
                string type = boxType.Content.ToString();
                if (size == "กลาง" && type == "แป้งหนานุ่ม")
                {
                    Result_price5.Content = "319";
                }
                if (size == "กลาง" && type == "แป้งบางกรอบ")
                {
                    Result_price5.Content = "219";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price5.Content = "419";
                }
                if (size == "กลาง" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price5.Content = "419";
                }
                if (size == "ใหญ่" && type == "แป้งหนานุ่ม")
                {
                    Result_price5.Content = "449";
                }
                if (size == "ใหญ่" && type == "แป้งบางกรอบ")
                {
                    Result_price5.Content = "349";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ขอบชีส")
                {
                    Result_price5.Content = "609";
                }
                if (size == "ใหญ่" && type == "เอ็กซ์ตรีม ไส้กรอกและชีส")
                {
                    Result_price5.Content = "609";
                }
            }
            catch
            {
                return;
            }
        }


        //---------------------------------------------------------------------------------------------------------//
    }
}
