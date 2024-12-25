using System.Windows;

namespace IMS.UserManagement
{
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("User");
            RoleComboBox.SelectedIndex = 0;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userId = UserIDTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string role = RoleComboBox.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                ErrorMessage.Text = "Please fill in all fields!";
                ErrorMessage.Visibility = Visibility.Visible;
            }
            else
            {

                ErrorMessage.Visibility = Visibility.Collapsed;


                if (ValidateLogin(userId, username, password, role))
                {
                    MessageBox.Show("Login Successful!");
                    this.Close();
                }
                else
                {

                    ErrorMessage.Text = "Invalid credentials or role!";
                    ErrorMessage.Visibility = Visibility.Visible;
                }
            }
        }

        private bool ValidateLogin(string userId, string username, string password, string role)
        {

            if (userId == "123" && username == "admin" && password == "admin123" && role == "Admin")
            {
                return true;
            }
            else if (userId == "124" && username == "user" && password == "user123" && role == "User")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}