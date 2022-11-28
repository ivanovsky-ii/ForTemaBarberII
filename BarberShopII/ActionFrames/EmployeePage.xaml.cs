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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        Employee emp = new Employee();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void AddEmpl_Click(object sender, RoutedEventArgs e)
        {
            emp.Name = AddNewEmplTbx.Text;

            conDB.bred.Employee.Add(emp);
            conDB.bred.SaveChanges();

            MessageBox.Show("Успешно");
            AddNewEmplTbx.Text = "";
        }
    }
}
