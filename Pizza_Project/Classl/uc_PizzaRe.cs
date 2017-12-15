using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Pizza_Project.UserController;

namespace Pizza_Project.Classlar
{
    public class uc_PizzaRe
    {
        public static void Uc_shop(Grid grd, UserControl uc)
        {
            if (grd.Children.Count > 0)
            {
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else { grd.Children.Add(uc); }
        }
    }
}
