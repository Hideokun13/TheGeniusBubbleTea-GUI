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
    /// Interaction logic for ToppingSelectorPage.xaml
    /// </summary>
    public partial class ToppingSelectorPage : Window
    {
        Beverage beverage = new Beverage();
        List<string> toppingList = new List<string>();

        public ToppingSelectorPage()
        {
            InitializeComponent();

            toppingList = LoadTopping();
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
            SweetSelectorPage sweetSelector = new SweetSelectorPage();
            sweetSelector.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectorPage menuSelector = new MenuSelectorPage();
            menuSelector.Show();
            this.Close();
        }


        //Bubble Selected


        private void AloeveraButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "อโลเวร่า");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void BrownsugarButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไข่มุกบราวน์ชูการ์");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void BubbleteaButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไข่มุก");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void BubbleteagoldButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไข่มุกทอง");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void FruityjellyButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "เยลลี่ผลไม้");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void SakurapearButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไข่มุกซากุระ");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void SnowpearButton_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไข่มุกสโนว์");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        private void NoTopping_Click(object sender, RoutedEventArgs e)
        {
            beverage.AddToppingToCart(toppingList, "ไม่มีท็อปปิ้ง");

            SweetSelectorPage sweet = new SweetSelectorPage();
            sweet.Show();
            this.Close();
        }
        public List<string> LoadTopping()
        {
            FileManagement toppingfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Beverage/Topping.txt");
            List<string> temp = new List<string>();
            foreach (string i in toppingfile.ReadFile())
            {
                temp.Add(i);
            }

            return temp;
        }
    }
}
