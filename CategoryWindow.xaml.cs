using System.Windows;
using System.Windows.Controls;

namespace IMS.MainMenu
{
    public partial class CategoryWindow : Window
    {
        public CategoryWindow()
        {
            InitializeComponent();
        }

        private void AddCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text) ||
                string.IsNullOrEmpty(CategoryNameTextBox.Text) ||
                string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before adding the category.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void UpdateCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text) ||
                string.IsNullOrEmpty(CategoryNameTextBox.Text) ||
                string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating the category.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Category updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void DeleteCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text))
            {
                MessageBox.Show("Please enter a Category ID to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearFields();
        }

        private void ClearFields()
        {
            CategoryIDTextBox.Clear();
            CategoryNameTextBox.Clear();
            DescriptionTextBox.Clear();
        }
    }
}
