using System.Windows;
using System.Windows.Controls;

namespace IMS.MainMenu
{
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(OrderIDTextBox.Text) ||
                string.IsNullOrEmpty(CustomerNameTextBox.Text) ||
                string.IsNullOrEmpty(ProductIDTextBox.Text) ||
                string.IsNullOrEmpty(QuantityTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before adding the order.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Order added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void UpdateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(OrderIDTextBox.Text) ||
                string.IsNullOrEmpty(CustomerNameTextBox.Text) ||
                string.IsNullOrEmpty(ProductIDTextBox.Text) ||
                string.IsNullOrEmpty(QuantityTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating the order.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Order updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(OrderIDTextBox.Text))
            {
                MessageBox.Show("Please enter an Order ID to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void ClearFields()
        {
            OrderIDTextBox.Clear();
            CustomerNameTextBox.Clear();
            ProductIDTextBox.Clear();
            QuantityTextBox.Clear();
        }
    }
}
