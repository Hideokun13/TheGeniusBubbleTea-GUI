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
    /// Interaction logic for MenuSelectorPage.xaml
    /// </summary>
    public partial class MenuSelectorPage : Window
    {
        public MenuSelectorPage()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void SelectTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TeaMenuSelector teaMenu = new TeaMenuSelector();
            teaMenu.Show();
            this.Close();
        }
        private void SelectSodaButton_Click(object sender, RoutedEventArgs e)
        {
            SodaMenuSelector sodaMenu = new SodaMenuSelector();
            sodaMenu.Show();
            this.Close();
        }
        private void SelectOtherButton_Click(object sender, RoutedEventArgs e)
        {
            OtherMenuSelector otherMenu = new OtherMenuSelector();
            otherMenu.Show();
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
        private void SelectMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            MilkTeaMenuSelector teaMenu = new MilkTeaMenuSelector();
            teaMenu.Show();
            this.Close();
        }
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //ToppingSelectorPage toppingSelector = new ToppingSelectorPage();
            //toppingSelector.Show();
            //this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        
    }
}
