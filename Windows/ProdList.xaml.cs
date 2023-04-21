using System;
using System.Collections.Generic;
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
using CoffeeHouse9_14.ClassHelper;
using static CoffeeHouse9_14.ClassHelper.EFClass;
using CoffeeHouse9_14.Windows;
using CoffeeHouse9_14.DB;
using static CoffeeHouse9_14.ClassHelper.CartClass;

namespace CoffeeHouse9_14.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProdList.xaml
    /// </summary>
    public partial class ProdList : Window
    {
        var selectedProduct = ;
        public ProdList()
        {
            InitializeComponent();
            GetProduct();
            if (EmployeeDataContext.employee.Post.Id!=1)
            {
                btnAdd.Visibility= Visibility.Hidden;
            }
            
        }
        private void GetProduct()
        {
            List<Product> ProdList = new List<Product>();
            ProdList = context.Product.ToList();
            LvProductList.ItemsSource = ProdList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditProductWindow addEditProductWindow = new AddEditProductWindow();
            addEditProductWindow.ShowDialog();
        }

        private void BtnGoToCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.Show();
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Product;



            if (selectedProduct != null)
            {
                ClassHelper.CartClass.Stuffs.Add(selectedProduct);
            }
        }
        private void CounterPrduct()
        {

            foreach (object val in Stuffs.Distinct())
            {

            }
            for (int i = 0; i < Stuffs.Count; i++)
            {
                if (Stuffs[i] == selectedProduct)
                {
                    //LvCartProductList.
                }
            }
        }
    }
}
