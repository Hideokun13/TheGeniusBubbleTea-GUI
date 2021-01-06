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
    /// Interaction logic for SweetSelectorPage.xaml
    /// </summary>
    public partial class SweetSelectorPage : Window
    {
        Beverage beverage = new Beverage();
        List<string> sweetLvList = new List<string>();

        public SweetSelectorPage()
        {
            InitializeComponent();

            sweetLvList = LoadSweetLv();
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
            SizeSelectorPage sizeSelector = new SizeSelectorPage(); 
            sizeSelector.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ToppingSelectorPage toppingSelector = new ToppingSelectorPage();
            toppingSelector.Show();
            this.Close();
        }

        //Sweet Selected


        private void NoSugarButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSweetToCart(sweetLvList, "ไม่หวาน");

            SizeSelectorPage size = new SizeSelectorPage();
            size.Show();
            this.Close();
        }
        private void HalfSugarButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSweetToCart(sweetLvList, "หวานน้อย");

            SizeSelectorPage size = new SizeSelectorPage();
            size.Show();
            this.Close();
        }
        private void FullSugarButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSweetToCart(sweetLvList, "หวานปกติ");

            SizeSelectorPage size = new SizeSelectorPage();
            size.Show();
            this.Close();
        }
        private void MoreSugarButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddSweetToCart(sweetLvList, "เพิ่มหวาน");

            SizeSelectorPage size = new SizeSelectorPage();
            size.Show();
            this.Close();
        }
        public List<string> LoadSweetLv()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/SweetLevel.txt");
            List<string> temp = new List<string>();
            foreach (string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
