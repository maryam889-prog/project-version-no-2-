using System.Windows;

namespace IMS.MainMenu
{
    public partial class ResultsPage : Window
    {
        public ResultsPage()
        {
            InitializeComponent();
        }

      
        private void DisplayResultButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Displaying the result details here...", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
