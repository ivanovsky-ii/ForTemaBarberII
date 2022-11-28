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

namespace BarberShopII.ActionFrames
{
    /// <summary>
    /// Логика взаимодействия для GoodsPage.xaml
    /// </summary>
    public partial class GoodsPage : Page
    {
        Material matr = new Material();
        public GoodsPage()
        {
            InitializeComponent();
            Comboboba.ItemsSource = conDB.bred.Maker.ToList();
        }

        private void AddGoodBtn_Click(object sender, RoutedEventArgs e)
        {
            matr.Name = AddMatrTbx.Text;
            matr.IdMaker = ((Maker)Comboboba.SelectedItem).Id;

            conDB.bred.Material.Add(matr);
            conDB.bred.SaveChanges();

            MessageBox.Show("Успешно");
            AddMatrTbx.Text = "";
            Comboboba.Text = "";
        }
    }
}
