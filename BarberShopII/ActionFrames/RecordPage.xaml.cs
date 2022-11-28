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
using BarberShopII.ActionFrames;

namespace BarberShopII.ActionFrames
{
    /// <summary>
    /// Логика взаимодействия для RecordPage.xaml
    /// </summary>
    public partial class RecordPage : Page
    {
        SummaryTable su = new SummaryTable();
        public RecordPage()
        {
            InitializeComponent();
            ChooseEmployee.ItemsSource = conDB.bred.Employee.ToList();
            ChooseMaterial.ItemsSource = conDB.bred.Material.ToList();
            ChooseMaker.ItemsSource = conDB.bred.Material.ToList();
        }

        private void NewRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            su.DateUse = (DateTime)YaKalendar.SelectedDate;
            su.IdEmployee = ((Employee)ChooseEmployee.SelectedItem).Id;
            su.IdMaterial = ((Material)ChooseMaterial.SelectedItem).Id;
            su.Price = Convert.ToDecimal(priceTbx.Text);
            su.Amount = Convert.ToInt32(amountTbx.Text);



            conDB.bred.SummaryTable.Add(su);
            conDB.bred.SaveChanges();

            MessageBox.Show("Успешно");

            NavigationCLass.MainAction.Navigate(new ActionFrames.AllViewPage());
        }
    }
}
