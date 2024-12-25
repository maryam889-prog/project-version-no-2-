using System.Windows;
using System.Windows.Controls; 
using System.Windows.Input;

namespace IMS.MainMenu
{
    public partial class SupplierWindow : Window
    {
        public SupplierWindow()
        {
            InitializeComponent();
        }

        private void AddSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SupplierNameTextBox.Text) ||
                string.IsNullOrEmpty(ContactNameTextBox.Text) ||
                string.IsNullOrEmpty(EmailTextBox.Text) ||
                string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before adding the supplier.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string supplierDetails = $"Supplier Name: {SupplierNameTextBox.Text}\n" +
                                     $"Contact Name: {ContactNameTextBox.Text}\n" +
                                     $"Email: {EmailTextBox.Text}\n" +
                                     $"Address: {AddressTextBox.Text}";

            SupplierDetailsStackPanel.Children.Clear(); 
            SupplierDetailsStackPanel.Children.Add(new TextBlock { Text = supplierDetails, Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White), FontSize = 16 });

            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

          
            ClearFields();
        }

        private void UpdateSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SupplierNameTextBox.Text) ||
                string.IsNullOrEmpty(ContactNameTextBox.Text) ||
                string.IsNullOrEmpty(EmailTextBox.Text) ||
                string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating the supplier.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

           
            string supplierDetails = $"Supplier Name: {SupplierNameTextBox.Text}\n" +
                                     $"Contact Name: {ContactNameTextBox.Text}\n" +
                                     $"Email: {EmailTextBox.Text}\n" +
                                     $"Address: {AddressTextBox.Text}";

            SupplierDetailsStackPanel.Children.Clear(); 
            SupplierDetailsStackPanel.Children.Add(new TextBlock { Text = supplierDetails, Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White), FontSize = 16 });

            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

     
        private void DeleteSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SupplierNameTextBox.Text))
            {
                MessageBox.Show("Please enter a Supplier Name to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

         
            ClearFields();
        }

  
        private void ClearFields()
        {
            SupplierNameTextBox.Clear();
            ContactNameTextBox.Clear();
            EmailTextBox.Clear();
            AddressTextBox.Clear();
        }
    }
}
