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
    /// Interaction logic for TeaMenuSelector.xaml
    /// </summary>
    public partial class TeaMenuSelector : Window
    {
        Beverage beverage = new Beverage();
        List<string> bevList = new List<string>();

        public TeaMenuSelector()
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


        private void MelonGreenTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวเมล่อน");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LightTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวใส");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void MilkTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวนม");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void HomeyLemonTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวน้ำผึ้งมะนาว");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void MelonTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเมล่อน");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void CoolTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเย็น");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void AppleTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเแอปเปิ้ล");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void ThaiTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาดำเย็น");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LemonTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชามะนาว");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LinGeeTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาลิ้นจี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void BlackTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาดำเย็น");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LemonGreenTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชามะนาว");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void LycheeGreenTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวลิ้นจี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void StrawberryTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาสตรอว์เบอร์รี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void StrawberryGreenTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวสตรอว์เบอร์รี่");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        private void AppleGreenTeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddDrinkToCart(bevList, "ชาเขียวแอปเปิ้ล");

            ToppingSelectorPage Topping = new ToppingSelectorPage();
            Topping.Show();
            this.Close();
        }
        

        //Method

        public List<string> LoadBeverage()
        {
            FileManagement bevfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/TeaMenu.txt");
            List<string> temp = new List<string>();
            foreach(string i in bevfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
