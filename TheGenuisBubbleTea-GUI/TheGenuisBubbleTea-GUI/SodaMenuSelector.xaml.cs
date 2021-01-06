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
    /// Interaction logic for SodaMenuSelector.xaml
    /// </summary>
    public partial class SodaMenuSelector : Window
    {
        Beverage beverage = new Beverage();
        List<string> bevList = new List<string>();
        public SodaMenuSelector()
        {
            InitializeComponent();

            bevList = LoadBeverage();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }


        private void ToppingSelectorPage_Click(object sender, RoutedEventArgs e)
        {
            ToppingSelectorPage ToppingSelector = new ToppingSelectorPage();
            ToppingSelector.Show();
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
            //MenuSelectorPage menuSelector = new MenuSelectorPage();
            //menuSelector.Show();
            //this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectorPage menuSelector = new MenuSelectorPage();
            menuSelector.Show();
            this.Close();
        }

        //Bubble Tea Selected


        private void MelonButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาลิ้นจี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void RedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "แดงโซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void RedLemonSodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "แดงมะนาวโซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void AppleSodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "แอปเปิ้ลโซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LemonSodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "มะนาวโซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LinGeeSodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ลิ้นจี่โซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void StawberrySodaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "สตรอว์เบอร์รี่โซดา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        //Method

        public List<string> LoadBeverage()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/SodaMenu.txt");
            List<string> temp = new List<string>();
            foreach (string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
