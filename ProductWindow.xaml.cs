using System.Windows;

namespace IMS.MainMenu
{
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ProductIDTextBox.Text) ||
                string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(SKUTextBox.Text) ||
                string.IsNullOrEmpty(CategoryTextBox.Text) ||
                string.IsNullOrEmpty(QuantityTextBox.Text) ||
                string.IsNullOrEmpty(UnitPriceTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before adding the product.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            
            ClearFields();
        }

        private void UpdateProductButton_Click(object sender, RoutedEventArgs e)
        {
         
            if (string.IsNullOrEmpty(ProductIDTextBox.Text) ||
                string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(SKUTextBox.Text) ||
                string.IsNullOrEmpty(CategoryTextBox.Text) ||
                string.IsNullOrEmpty(QuantityTextBox.Text) ||
                string.IsNullOrEmpty(UnitPriceTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating the product.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            
            ClearFields();
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
        
            if (string.IsNullOrEmpty(ProductIDTextBox.Text))
            {
                MessageBox.Show("Please enter a Product ID to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

   
        private void ClearFields()
        {
            ProductIDTextBox.Clear();
            NameTextBox.Clear();
            SKUTextBox.Clear();
            CategoryTextBox.Clear();
            QuantityTextBox.Clear();
            UnitPriceTextBox.Clear();
        }
    }
}
