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

namespace BushmelevExamen.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public List<UserControls.ProductControl> productControls = new List<UserControls.ProductControl>();
        bool beginSort = false;
        bool beginFilter = false;
        public PageProduct()
        {
            InitializeComponent();
            LoadData();
            //foreach (var product in Classes.ConnectDB.tradeEntities.Product.ToList())
            //{
            //    UserControls.ProductControl productControl = new UserControls.ProductControl(product);
            //    productControls.Add(productControl);
            //}
            //listBoxProducts.ItemsSource = productControls;
            //txtBlockItemsCount.Text = productControls.Count.ToString() + "/" + productControls.Count.ToString();
            cmBoxSort.Items.Add("-сортировка-");
            cmBoxSort.Items.Add("По убыванию");
            cmBoxSort.Items.Add("По возрастанию");
            cmBoxSort.SelectedIndex = 0;
            cmBoxFilter.Items.Add("-фильтр-");
            cmBoxFilter.Items.Add("0-9,99%");
            cmBoxFilter.Items.Add("10-14,99%");
            cmBoxFilter.Items.Add("15% и более");
            cmBoxFilter.SelectedIndex = 0;
        }

        public void LoadData()
        {
            productControls.Clear();
            foreach (var product in Classes.ConnectDB.tradeEntities.Product.ToList())
            {
                UserControls.ProductControl productControl = new UserControls.ProductControl(product);
                productControls.Add(productControl);
            }
            listBoxProducts.ItemsSource = productControls;
            txtBlockItemsCount.Text = productControls.Count.ToString() + "/" + productControls.Count.ToString();
        }

        private void SearchSortFilter()
        {
            var products = productControls.Where(p => p.txtBlockProductName.Text.Contains(txtBoxSearch.Text) || p.txtBlockProductDescription.Text.Contains(txtBoxSearch.Text));
            if (beginSort)
            {
                if (cmBoxSort.SelectedValue.ToString() == "По убыванию")
                {
                    products = products.OrderByDescending(p => Convert.ToInt32(p.txtBlockCost.Text));
                }
                if (cmBoxSort.SelectedValue.ToString() == "По возрастанию")
                {
                    products = products.OrderBy(p => Convert.ToInt32(p.txtBlockCost.Text));
                }
            }
            if (beginFilter)
            {
                if (cmBoxFilter.SelectedIndex == 1)
                {
                    products = products.Where(p => p.txtBlockProductDiscountAmount.Text.Length > 0 && Convert.ToInt32(p.txtBlockProductDiscountAmount.Text) >= 0 && Convert.ToInt32(p.txtBlockProductDiscountAmount.Text) < 10);
                }
                if (cmBoxFilter.SelectedIndex == 2)
                {
                    products = products.Where(p => p.txtBlockProductDiscountAmount.Text.Length > 0 && Convert.ToInt32(p.txtBlockProductDiscountAmount.Text) >= 10 && Convert.ToInt32(p.txtBlockProductDiscountAmount.Text) < 15);
                }
                if (cmBoxFilter.SelectedIndex == 3)
                {
                    products = products.Where(p => p.txtBlockProductDiscountAmount.Text.Length > 0 && Convert.ToInt32(p.txtBlockProductDiscountAmount.Text) >= 15);
                }
            }
            listBoxProducts.ItemsSource = products;
            txtBlockItemsCount.Text = products.ToList().Count.ToString() + "/" + productControls.Count.ToString();
        }

        private void txtBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchSortFilter();
        }

        private void cmBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmBoxSort.SelectedValue.ToString() == "-сортировка-")
                beginSort = false;
            else
                beginSort = true;
            SearchSortFilter();
        }

        private void cmBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmBoxFilter.SelectedValue.ToString() == "-фильтр-")
                beginFilter = false;
            else
                beginFilter = true;
            SearchSortFilter();
        }
    }
}
