using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using static CoffeeHouse9_14.ClassHelper.CartClass;
using static CoffeeHouse9_14.ClassHelper.EFClass;

namespace CoffeeHouse9_14.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public object selProduct;
        public CartWindow()
        {
            InitializeComponent();
            GetListProduct();
            
           
            
        }
        private void GetListProduct()
        {
            ObservableCollection<DB.Product> stuffs = new ObservableCollection<DB.Product>(ClassHelper.CartClass.Stuffs);

            LvCartProductList.ItemsSource = stuffs;
        }

        private void BtnRemoveToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            var selectedProduct = button.DataContext as DB.Product;


            if (selectedProduct != null)
            {

                if (selectedProduct.Quantity == 1 || selectedProduct.Quantity == 0)
                {
                    Stuffs.Remove(selectedProduct);
                }
                else
                {
                    selectedProduct.Quantity--;
                    int o = Stuffs.IndexOf(selectedProduct);
                    Stuffs.Remove(selectedProduct);
                    Stuffs.Insert(o, selectedProduct);
                }
            }
            GetListProduct();
           
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            DB.Product selectedProduct = button.DataContext as DB.Product;
            if (selectedProduct != null)
            {
                selectedProduct.Quantity++;
                int o = Stuffs.IndexOf(selectedProduct);
                Stuffs.Remove(selectedProduct);
                Stuffs.Insert(o, selectedProduct);
            }
            GetListProduct();
        }

        private void Pokupka_Click(object sender, RoutedEventArgs e)
        {
            DB.Sale sale = new DB.Sale();
            sale.IdEmployee = ClassHelper.EmployeeDataContext.employee.Id;
            sale.IdClient = 1;
            sale.Date = DateTime.Now;
            if (sale != null)
            {
                context.Sale.Add(sale);
                context.SaveChanges();
            }


            foreach (var item in Stuffs)
            {
                DB.ProductSale prodSale = new DB.ProductSale();
                prodSale.IdProduct = item.Id;
                prodSale.Quantity = item.Quantity;
                prodSale.IdSale= context.Sale.ToList().LastOrDefault().Id;
                context.ProductSale.Add(prodSale);
                context.SaveChanges();
            }
            MessageBox.Show("Продукты успешно куплены");
            ProdList prodList = new ProdList();
            prodList.Show();
            Close();
        }
    }
}
