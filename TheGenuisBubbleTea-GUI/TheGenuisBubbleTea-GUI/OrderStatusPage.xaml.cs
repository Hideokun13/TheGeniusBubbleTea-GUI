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
    /// Interaction logic for OrderStatusPage.xaml
    /// </summary>
    public partial class OrderStatusPage : Window
    {
        List<Cart> OrderList = new List<Cart>();
        FileManagement logfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Cart/logfile.txt");
        string namewater;
        string pricewater;
        string toppping;
        string pricetopping;
        string sweetlevel;
        string size;
        string pricesize;
        public OrderStatusPage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            MenuSelectorPage menuSelector = new MenuSelectorPage();
            menuSelector.Show();
            this.Close();
        }

        private void MemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberPage member = new MemberPage();
            member.Show();
            this.Close();
        }

        private void RefreshDataButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Clear();
            LoadCart();
            OrderStatusList.ItemsSource = OrderList;
            OrderStatusList.Items.Refresh();
        }

        public void LoadCart()
        {
            
            foreach (string i in logfile.ReadFile())
            {
                
                if (i != "")
                {
                    string[] data = new string[7];
                    data = i.Split(',');
                    this.namewater = data[0];
                    this.pricewater = data[1];
                    this.toppping = data[2];
                    this.pricetopping = data[3];
                    this.sweetlevel = data[4];
                    this.size = data[5];
                    this.pricesize = data[6];

                    Cart cart = new Cart(namewater, pricewater, toppping, pricetopping, sweetlevel, size, pricesize);
                    OrderList.Add(cart);
                }
            }

        }

        private void ClearhButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> temp = new List<string>();
            string text = "DEL TEXT";
            temp.Add(text);
            logfile.WriteFile(temp);

            RefreshDataButton_Click(sender, e);
            OrderStatusList.Items.Refresh();
        }
    }
}
