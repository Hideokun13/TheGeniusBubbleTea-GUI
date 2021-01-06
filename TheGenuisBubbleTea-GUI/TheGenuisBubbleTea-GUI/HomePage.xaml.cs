using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TheGenuisBubbleTea_GUI
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectorPage menuSelector = new MenuSelectorPage();
            menuSelector.Show();
            this.Close();
        }

        private void OrderStatusButton_Click(object sender, RoutedEventArgs e)
        {
            OrderStatusPage orderStatus = new OrderStatusPage();
            orderStatus.Show();
            this.Close();
        }

        private void MemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberPage member = new MemberPage();
            member.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure to logout?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void BuyITNow_Click(object sender, RoutedEventArgs e)
        {
            OtherMenuSelector otherMenu = new OtherMenuSelector();
            otherMenu.Show();
            this.Close();
        }
    }
}
