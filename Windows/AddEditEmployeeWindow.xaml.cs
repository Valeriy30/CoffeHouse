using CoffeeHouse9_14.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для AddEditEmployeeWindow.xaml
    /// </summary>
    public partial class AddEditEmployeeWindow : Window
    {
        private Employee employee = new Employee();
        private Account account = new Account();    
        public AddEditEmployeeWindow()
        {
            InitializeComponent();
            cmbPost.ItemsSource = context.Post.ToList();
            cmbPost.DisplayMemberPath = "Title";
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            account.FirstName = tbFname.Text;
            account.LastName = tbLname.Text;
            account.Patronymic = tbPatronymic.Text;
            account.BirthDay = dpBirthDay.SelectedDate.Value;
            account.Login = tbLogin.Text;
            account.Password = tbPass.Text;
            account.Phone = tbPhone.Text;
            context.Account.AddOrUpdate(account);
            context.SaveChanges();
            employee.IdPost = (cmbPost.SelectedItem as Post).Id;
            employee.IdAccount = context.Account.ToList().Where(i => i.Login== tbLogin.Text).FirstOrDefault().Id;
            context.Employee.AddOrUpdate(employee);
            context.SaveChanges();
        }
    }
}
