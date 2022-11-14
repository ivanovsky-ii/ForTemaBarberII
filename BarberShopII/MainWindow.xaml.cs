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
using BarberShopII.ActionFrames;
using BarberShopII.DB;

namespace BarberShopII
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationCLass.MainAction = MainFrame;
            MainFrame.Navigate(new ActionFrames.MainActionPage());

            NavigationCLass.MenuAction = MenuFrame;
            MenuFrame.Navigate(new ActionFrames.MainMenuPage());

        }
    }
}
