using System.Windows;

namespace PharmacyManagementSystem
{
    public partial class SideBar : Window
    {
        public SideBar()
        {
            InitializeComponent();
            // Optionally load the Dashboard when the window first appears
            MainContent.Content = new Dashboard();
        }

        private void SideBarDashboardItem_OnClick(object sender, RoutedEventArgs e)
        {
            // Load the Dashboard user control inside the ContentControl
            MainContent.Content = new Dashboard();
        }

        private void SideBarAddUserItem_OnClick(object sender, RoutedEventArgs e)
        {
            // Placeholder for Add User functionality
            MainContent.Content = new AddUser();
        }

        private void SideBarProfile_OnClick(object sender, RoutedEventArgs e)
        {
            // Placeholder for View Users functionality
            MainContent.Content = new Profile();
        }
    }
}