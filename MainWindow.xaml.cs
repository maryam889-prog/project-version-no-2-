using System.Windows;
using IMS.UserManagement; 

namespace IMS.MainMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowProductsButton_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
            this.Close();  
        }

       
        private void ShowCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow categoryWindow = new CategoryWindow();
            categoryWindow.Show();
            this.Close();  
        }

        private void ShowOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();  
        }

        
        private void ShowUsersButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow(); 
            userWindow.Show();
            this.Close();  
        }

       
        private void ShowSuppliersButton_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow supplierWindow = new SupplierWindow();
            supplierWindow.Show();
            this.Close();  
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            
            ResultsPage resultsPage = new ResultsPage();
            resultsPage.Show(); 
        }




        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow();
            exitWindow.ShowDialog();  
        }
    }
}
