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
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportSaleWindow : Window
    {
        public ReportSaleWindow()
        {
            InitializeComponent();
            dgSale.ItemsSource = context.ProductSale.ToList();
            for (int i = 0; i < 11; i++)
            {
                cmbYear.Items.Add(DateTime.Now.Year-i);
            }
        }   
        private void dpSecond_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFirst.SelectedDate != null)
            {
                dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpFirst.SelectedDate.Value && i.Sale.Date < dpSecond.SelectedDate.Value);
            }
            else
            {
                dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpSecond.SelectedDate.Value);
            }
        }

        private void dpFirst_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpSecond.SelectedDate != null)
            {
                dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpFirst.SelectedDate.Value && i.Sale.Date < dpSecond.SelectedDate.Value);
            }
            else
            {
                dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpFirst.SelectedDate.Value);
            }
        }

        private void cmbMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime date2 = new DateTime(DateTime.Now.Year, 1, 31);
            switch (cmbMonth.SelectedIndex) 
            {

                case 0:
                    date = new DateTime(DateTime.Now.Year,1,1);
                    date2 = new DateTime(DateTime.Now.Year,1,31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date&&i.Sale.Date<date2);
                    break;
                case 1:
                     date = new DateTime(DateTime.Now.Year, 2, 1);
                     date2 = new DateTime(DateTime.Now.Year, 2, 28);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 2:
                     date = new DateTime(DateTime.Now.Year, 3, 1);
                     date2 = new DateTime(DateTime.Now.Year, 3, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 3:
                     date = new DateTime(DateTime.Now.Year, 4, 1);
                     date2 = new DateTime(DateTime.Now.Year, 4, 30);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 4:
                     date = new DateTime(DateTime.Now.Year, 5, 1);
                     date2 = new DateTime(DateTime.Now.Year, 5, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 5:
                     date = new DateTime(DateTime.Now.Year, 6, 1);
                     date2 = new DateTime(DateTime.Now.Year, 6, 30);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 6:
                     date = new DateTime(DateTime.Now.Year, 7, 1);
                     date2 = new DateTime(DateTime.Now.Year, 7, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 7:
                     date = new DateTime(DateTime.Now.Year, 8, 1);
                     date2 = new DateTime(DateTime.Now.Year, 8, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 8:
                     date = new DateTime(DateTime.Now.Year, 9, 1);
                     date2 = new DateTime(DateTime.Now.Year, 9, 30);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 9:
                     date = new DateTime(DateTime.Now.Year, 10, 1);
                     date2 = new DateTime(DateTime.Now.Year, 10, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 10:
                     date = new DateTime(DateTime.Now.Year, 11, 1);
                     date2 = new DateTime(DateTime.Now.Year, 11, 30);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 11:
                     date = new DateTime(DateTime.Now.Year,12,1);
                     date2 = new DateTime(DateTime.Now.Year,12,31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date&&i.Sale.Date<date2);
                    break;
                



            }
        }

        private void cmbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = new DateTime(DateTime.Now.Year,1,1);
            DateTime date2 = new DateTime(DateTime.Now.Year,12,31);
            switch (cmbYear.SelectedIndex) 
            {
                case 0:
                    
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 1:
                    date = new DateTime((DateTime.Now.Year-1),1,1);
                    date2 = new DateTime((DateTime.Now.Year-1),12,31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                   
                    break;
                case 2:
                    date = new DateTime((DateTime.Now.Year - 2), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 2), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 3:
                    date = new DateTime((DateTime.Now.Year - 3), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 3), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 4:
                    date = new DateTime((DateTime.Now.Year - 4), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 4), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 5:
                    date = new DateTime((DateTime.Now.Year - 5), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 5), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 6:
                    date = new DateTime((DateTime.Now.Year - 6), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 6), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 7:
                    date = new DateTime((DateTime.Now.Year - 7), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 7), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 8:
                    date = new DateTime((DateTime.Now.Year - 8), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 8), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                case 9:
                    date = new DateTime((DateTime.Now.Year - 9), 1, 1);
                    date2 = new DateTime((DateTime.Now.Year - 9), 12, 31);
                    dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > date && i.Sale.Date < date2);
                    break;
                
            }
        }
    }
}
