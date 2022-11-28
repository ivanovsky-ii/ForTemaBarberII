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
using BarberShopII.DB;

namespace BarberShopII.ActionFrames
{
    /// <summary>
    /// Логика взаимодействия для AllViewPage.xaml
    /// </summary>
    public partial class AllViewPage : Page
    {
        public AllViewPage()
        {
            InitializeComponent();
            //PPPk.ItemsSource = conDB.bred.SummaryTable.ToList();
            EmplCmbx.ItemsSource = conDB.bred.Employee.ToList();

            
        }

        private void EmplCmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PPPk.ItemsSource = conDB.bred.SummaryTable.Where(io => io.IdEmployee == ((Employee)EmplCmbx.SelectedItem).Id).ToList();
        }
    }
}
