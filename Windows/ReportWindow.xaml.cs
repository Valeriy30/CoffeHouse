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
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
            dgSale.ItemsSource = context.ProductSale.ToList();
            
        }

        private void dpSecond_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFirst.SelectedDate.Value != null)
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
            if (dpSecond.SelectedDate == null)
            {
                dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpFirst.SelectedDate.Value);
            }
            else
            {
                  dgSale.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dpFirst.SelectedDate.Value&& i.Sale.Date < dpSecond.SelectedDate.Value);

            }
        }
    }
}
