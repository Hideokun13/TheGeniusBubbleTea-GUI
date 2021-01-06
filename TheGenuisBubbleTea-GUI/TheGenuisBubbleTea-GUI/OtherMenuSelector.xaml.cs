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
    /// Interaction logic for OtherMenuSelector.xaml
    /// </summary>
    public partial class OtherMenuSelector : Window
    {
        Beverage beverage = new Beverage();
        List<string> bevList = new List<string>();
        public OtherMenuSelector()
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

        //Bubble Tea Selected


        private void CocoButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "โกโก้");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void OwantinButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "โอวัลติน,");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void CoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "กาแฟ");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void MoccaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "มอคค่า");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LateButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "กาแฟลาเต้");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void MaliTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวมะลิ");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void MilkPinkButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "นมชมพู");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
          }
        private void HoneyButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "น้ำผึ้งมะนาว");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }

        //Method

        public List<string> LoadBeverage()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/OtherMenu.txt");
            List<string> temp = new List<string>();
            foreach (string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}