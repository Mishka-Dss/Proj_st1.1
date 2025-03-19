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

namespace WpfAppKolodchenkoVitaly
{
    /// <summary>
    /// Логика взаимодействия для DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        private object dbContext;

        public DataGrid()
        {
            InitializeComponent();
        }

        public object DbContext { get => dbContext; set => dbContext = value; }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Products selectedProduct = ProductsDataGrid.SelectedItem as Products;
            if (selectedProduct == null) 
            {
                MassageBox.Show("Выберите товар для редактирования");
                return;
            }
            {
                AddEditProductWindow editWindow = new AddEditProductWindow(selectedProduct, DbContext);
                {
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }
    }

    internal class AddEditProductWindow
    {
        private Products selectedProduct;
        private object dbContext;

        public AddEditProductWindow(Products selectedProduct, object dbContext)
        {
            this.SelectedProduct = selectedProduct;
            this.DbContext = dbContext;
        }

        public object DbContext { get => dbContext; set => dbContext = value; }
        internal Products SelectedProduct { get => selectedProduct; set => selectedProduct = value; }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }
    }

    internal class MassageBox
    {
        internal static void Show(string v)
        {
            throw new NotImplementedException();
        }
    }

    internal class Products
    {
    }
}

