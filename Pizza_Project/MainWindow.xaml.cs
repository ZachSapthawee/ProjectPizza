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
using Pizza_Project.Classlar;
using Pizza_Project.UserController;

namespace Pizza_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
             Environment.Exit(0);
        }
    
        private void brd_Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btn_RestoreDown_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;

            }
            else
            {
                this.WindowState = WindowState.Normal;
            }

        }

        private void btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_hamburgerMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(btn_hamburgerMenu.Width != 60)
            {
            GridLength grd = new GridLength(80, GridUnitType.Pixel);
            grdClen_menu.Width = grd;

            lbl_Menu1.Visibility = Visibility.Hidden;
            lbl_Menu2.Visibility = Visibility.Hidden;
            lbl_Menu3.Visibility = Visibility.Hidden;
            lbl_Menu4.Visibility = Visibility.Hidden;
            lbl_Menu5.Visibility = Visibility.Hidden;
            lbl_Menu6.Visibility = Visibility.Hidden;
            lbl_Menu7.Visibility = Visibility.Hidden;

             

            lbl_logozak.Width = 0;
            btn_hamburgerMenu.Width= 60;
            Menu_lblver_border.Visibility = Visibility.Hidden;
            Menu_pizza_hut_Crop.Visibility = Visibility.Hidden;

            }
            else
            {
                GridLength grd = new GridLength(250, GridUnitType.Pixel);
                grdClen_menu.Width = grd;

                lbl_Menu1.Visibility = Visibility.Visible;
                lbl_Menu2.Visibility = Visibility.Visible;
                lbl_Menu3.Visibility = Visibility.Visible;
                lbl_Menu4.Visibility = Visibility.Visible;
                lbl_Menu5.Visibility = Visibility.Visible;
                lbl_Menu6.Visibility = Visibility.Visible;
                lbl_Menu7.Visibility = Visibility.Visible;

                

                lbl_logozak.Width = 250;
                btn_hamburgerMenu.Width = 1000;
                Menu_lblver_border.Visibility = Visibility.Visible;
                Menu_pizza_hut_Crop.Visibility = Visibility.Visible;
            }

        }

       public void menubutton_Promo_Click(object sender, RoutedEventArgs e)
       {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Menu01xaml());
        }

        private void PizzaForm_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_Wellcom.Content = "ยินดีต้อนรับ";
        }

        private void menubutton_Pizza_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UcPizza01());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Menu03());
        }

        private void Menu_04_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Manu04());
        }

        private void Menu_05_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Menu05());
        }

        private void Menu_6_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Menu06());
        }

        private void Menu_07_Click(object sender, RoutedEventArgs e)
        {
            uc_PizzaRe.Uc_shop(content_MENUShoping, new UC_Menu07());
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Badget Bad = new Badget();
            Bad.Show();
        }
    }
}
