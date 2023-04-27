using CoffeeHouse9_14.ClassHelper;
using CoffeeHouse9_14.Windows;
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
using static CoffeeHouse9_14.ClassHelper.EFClass;

namespace CoffeeHouse9_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbFI.Text=EmployeeDataContext.employee.Account.FirstName.ToString()+" "+ EmployeeDataContext.employee.Account.LastName.ToString() + " \\ " + EmployeeDataContext.employee.Post.Title.ToString();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            ProdList prodList = new ProdList();
            this.Hide();
            prodList.ShowDialog();
            this.Show();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Show();
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountList accountList = new AccountList();
            this.Hide();
            accountList.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow(); 
            this.Hide();
            reportWindow.ShowDialog();
            this.Show();
        }
    }
}
