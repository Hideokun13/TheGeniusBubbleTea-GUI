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
    /// Interaction logic for MilkTeaMenuSelector.xaml
    /// </summary>
    public partial class MilkTeaMenuSelector : Window
    {
        Beverage beverage = new Beverage();
        List<string> bevList = new List<string>();
        public MilkTeaMenuSelector()
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

        private void TaiwanMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมไต้หวัน");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void CoffeeMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมกาแฟ");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void CocoaMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมโกโก้");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void TaroMilkTea_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมเผือก");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void LycheeMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมลิ้นจี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void MelonMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมเมล่อน");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void StrawberryMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมสตรอว์เบอร์รี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void AppleMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมแอปเปิ้ล");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void CaramelMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมคาราเมล");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void VanillaMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมวานิลลา");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        private void HoneyMilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชานมน้ำผึ้ง");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        //Method

        public List<string> LoadBeverage()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/MilkTeaMenu.txt");
            List<string> temp = new List<string>();
            foreach (string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
