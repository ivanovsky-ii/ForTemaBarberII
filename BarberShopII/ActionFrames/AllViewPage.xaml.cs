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
        public AllViewPage(Employee emp)
        {
            InitializeComponent();
            //PPPk.ItemsSource = conDB.bred.SummaryTable.ToList();
            EmplCmbx.ItemsSource = conDB.bred.Employee.ToList();
            EmplCmbx.SelectedItem = emp;
            
        }
        public AllViewPage()
        {
            InitializeComponent();
            //PPPk.ItemsSource = conDB.bred.SummaryTable.ToList();
            EmplCmbx.ItemsSource = conDB.bred.Employee.ToList();


        }

        private void EmplCmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PPPk.ItemsSource = conDB.bred.SummaryTable.Where(io => io.IdEmployee == ((Employee)EmplCmbx.SelectedItem).Id).ToList();
            var countRec = conDB.bred.SummaryTable.Where(po => po.IdEmployee == ((Employee)EmplCmbx.SelectedItem).Id).Count();

            AllRecTbx.Text = Convert.ToString(countRec);

            var countZP = conDB.bred.SummaryTable.Where(op => op.IdEmployee == ((Employee)EmplCmbx.SelectedItem).Id).Sum(jj => jj.Sum);

            SumTbx.Text = Convert.ToString(countZP);

        }

        private void GoToPerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationCLass.MainAction.Navigate(new ActionFrames.PeriodPage());
        }
    }
}
