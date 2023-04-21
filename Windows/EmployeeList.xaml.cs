using CoffeeHouse9_14.ClassHelper;
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
using System.Windows.Shapes;
using static CoffeeHouse9_14.ClassHelper.EFClass;

namespace CoffeeHouse9_14.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        public EmployeeList()
        {
            InitializeComponent();
          
            dgEmployee.ItemsSource = context.Employee.ToList();
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditEmployeeWindow addEditEmployee = new AddEditEmployeeWindow();
            this.Hide();
            addEditEmployee.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Изменено");
        }

        private void dgEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock tbCH = dgEmployee.Columns[0].GetCellContent(dgEmployee.Items[dgEmployee.SelectedIndex]) as TextBlock;
        }
    }
}
