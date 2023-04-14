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

namespace BushmelevExamen.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        DataBaseModel.Product prod;
        public ProductControl(DataBaseModel.Product product)
        {
            InitializeComponent();
            prod = product;
            txtBlockCost.Text = Convert.ToInt32(product.ProductCost).ToString();
            txtBlockProductDescription.Text = product.ProductDescription;
            txtBlockProductDiscountAmount.Text = product.ProductDiscountAmount.ToString();
            imgProduct.Source = new BitmapImage(new Uri($@"../Images/{product.ProductPhoto}", UriKind.RelativeOrAbsolute));
            txtBlockProductManufacturer.Text = product.ProductManufacturer1.ProductManufacturerName;
            txtBlockProductName.Text = product.ProductName1.ProductNameName;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Удаление товара", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //Classes.ConnectDB.tradeEntities.Product.Remove(prod);
            //Classes.ConnectDB.tradeEntities.SaveChanges();
            //Classes.Pages.pageProduct.LoadData();
        }
    }
}
