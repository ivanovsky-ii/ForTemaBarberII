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
    /// Логика взаимодействия для AddNewMakerPage.xaml
    /// </summary>
    public partial class AddNewMakerPage : Page
    {
        public AddNewMakerPage()
        {
            InitializeComponent();
        }
        Maker m = new Maker();

        private void AddNewMakerBtn_Click(object sender, RoutedEventArgs e)
        {
            m.Name = AddMakerTbx.Text;

            conDB.bred.Maker.Add(m);
            conDB.bred.SaveChanges();

            MessageBox.Show("Успешно");
            AddMakerTbx.Text = "";
            
        }
    }
}
