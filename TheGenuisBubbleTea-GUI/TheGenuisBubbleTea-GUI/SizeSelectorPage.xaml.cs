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
    /// Interaction logic for SizeSelectorPage.xaml
    /// </summary>
    public partial class SizeSelectorPage : Window
    {
        Beverage beverage = new Beverage();
        List<string> sizeList = new List<string>();

        public SizeSelectorPage()
        {
            InitializeComponent();

            sizeList = LoadSize();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
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
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            SummaryPage summary = new SummaryPage();
            summary.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SweetSelectorPage sweetSelector = new SweetSelectorPage();
            sweetSelector.Show();
            this.Close();
        }



        //Size Selected

        private void SizeSButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSizeToCart(sizeList, "Size S");

            SummaryPage summary = new SummaryPage();
            summary.Show();
            this.Close();
        }
        private void SizeMButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSizeToCart(sizeList, "Size M");

            SummaryPage summary = new SummaryPage();
            summary.Show();
            this.Close();
        }
        private void SizeLButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSizeToCart(sizeList, "Size L");

            SummaryPage summary = new SummaryPage();
            summary.Show();
            this.Close();
        }
        private void SizeXLButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSizeToCart(sizeList, "Size XL");

            SummaryPage summary = new SummaryPage();
            summary.Show();
            this.Close();
        }

        public List<string> LoadSize()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/Size.txt");
            List<string> temp = new List<string>();
            foreach (string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
