using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Oracle.ManagedDataAccess.Client;

namespace PharmacyManagementSystem
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            UsernameTextbox.Focus();
        }
        
        private void UsernameTextbox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (UsernamePlaceholderText.Text == "USERNAME")
            {
                UsernamePlaceholderText.Text = "";
            }
        }
        
        private void PasswordTextbox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordPlaceholderText.Text == "PASSWORD")
            {
                PasswordPlaceholderText.Text = "";
            }
        }
        private void UsernameTextbox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextbox.Text == "")
            {
                UsernamePlaceholderText.Text = "USERNAME";
            }
        }

        private void PasswordTextbox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextbox.Password == "")
            {
                PasswordPlaceholderText.Text = "PASSWORD";
            }
        }


        private void UsernameTextbox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                PasswordTextbox.Focus();
            }
        }
        private void PasswordTextbox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                LoginButton_OnClick(null, null);
            }
        }
        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
             String username = UsernameTextbox.Text;
             String password = PasswordTextbox.Password;
             try
             {
                 String connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/orcl";
                 OracleConnection conn = new OracleConnection(connectionString);
                 
                 
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error" + ex.Message);
                 UsernameTextbox.Clear();
                 PasswordTextbox.Clear();
                 UsernameTextbox.Focus();
             }
        }
    }
}