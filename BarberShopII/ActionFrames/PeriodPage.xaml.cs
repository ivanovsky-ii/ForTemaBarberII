using BarberShopII.DB;
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

namespace BarberShopII.ActionFrames
{
    /// <summary>
    /// Логика взаимодействия для PeriodPage.xaml
    /// </summary>
    public partial class PeriodPage : Page
    {
        public PeriodPage()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(YaKalendar.Text))
            {
                mes += "Выберите начало периода \n";
            }
            else if (string.IsNullOrWhiteSpace(YaNeKalendar.Text))
            {
                mes += "Выберите конец периода \n";
            }
            else if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
            }

            var startPeriod = (DateTime)YaKalendar.SelectedDate;
            var endPeriod = (DateTime)YaNeKalendar.SelectedDate;



            showDG.ItemsSource = conDB.bred.Prikol
                .Where(io => io.DateUse >= startPeriod && io.DateUse <= endPeriod)
                .GroupBy(p => p.Name)
                .Select(l => new { Сотрудник = l.Key, Сумма = l.Sum(s => s.Sum) })
                .OrderBy(emp => emp.Сотрудник)
                .ToList();


        }
    }
}
