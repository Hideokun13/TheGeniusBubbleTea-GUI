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
    /// Interaction logic for SummaryPage.xaml
    /// </summary>
    public partial class SummaryPage : Window
    {
        Cart cart = new Cart();
        Member member = new Member();
        List<string> cartList = new List<string>();
        FileManagement registerFile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Member/Member.txt");
        FileManagement cartFile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Cart/Cart.txt");
        string namewater;
        string pricewater;
        string toppping;
        string pricetopping;
        string sweetlevel;
        string size;
        string pricesize;
        string total;
        string totalsum;
        string discount;
        string change;
        public SummaryPage()
        {
            InitializeComponent();
            Total();
            LoadCart();
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
        private void EndButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SizeSelectorPage sizeSelector = new SizeSelectorPage();
            sizeSelector.Show();
            this.Close();
        }

        public void LoadCart()
        {
            foreach (string i in cartFile.ReadFile())
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
                }
                drinkNameBlock.Inlines.Add(new Bold(new Run(namewater)));
                drinkPriceBlock.Inlines.Add(new Bold(new Run(pricewater)));
                toppingNameBlock.Inlines.Add(new Bold(new Run("    -" + toppping)));
                toppingPriceBlock.Inlines.Add(new Bold(new Run(pricetopping)));
                sweetLevelBlock.Inlines.Add(new Bold(new Run("    -" + sweetlevel)));
                addSweetPriceBlock.Inlines.Add(new Bold(new Run("-")));
                sizeBlock.Inlines.Add(new Bold(new Run("    -" + size)));
                addSizeBlock.Inlines.Add(new Bold(new Run(pricesize)));
                sumBlock.Inlines.Add(new Bold(new Run(total)));
            }

        }
        public void Total()
        {

            foreach (string i in cartFile.ReadFile())
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
                }
            }
            int water = Int32.Parse(this.pricewater);
            int toppoing = Int32.Parse(this.pricetopping);
            int pricesize = Int32.Parse(this.pricesize);
            int totalint = water + toppoing + pricesize;
            this.total = totalint.ToString();

        }

        public void Summary()
        {
            int totals = Int32.Parse(this.total);
            int dis = Int32.Parse(this.discount);

            int summary = totals - ((totals * dis) / 100);
            this.totalsum = summary.ToString();


        }

        public void Summary_()
        {
            int totals = Int32.Parse(this.total);
            int summary = totals;
            this.totalsum = summary.ToString();


        }

        public void Change()
        {
            int totals = Int32.Parse(this.totalsum);
            int get = Int32.Parse(GetMoney.Text);
            if (get > 0)
            {
                int change_ = get - totals;
                this.change = change_.ToString();
                changemoney.Text = this.change;
            }
            else
            {
                int change_ = 0;
                this.change = change_.ToString();
                changemoney.Text = this.change;
            }
            
        }

        private void CheckTelnumber_Click(object sender, RoutedEventArgs e)
        {
            if (member.CheckMember(Telnumber.Text))
            {
                this.discount = "10";
                MessageBox.Show("Got Discount 10%", "ได้รับส่วนลดเรียบร้อย", MessageBoxButton.OK, MessageBoxImage.Information);
                Summary();

                Discounttext.Text = this.discount + " %";
                Sumary.Text = this.totalsum;

            }
            else
            {
                this.discount = "0";
                Summary_();
                MessageBox.Show("Dont have this member", "ไม่ได้รับส่วนลด", MessageBoxButton.OK, MessageBoxImage.Information);
                Discounttext.Text = this.discount;
                Sumary.Text = this.totalsum;
            }

        }
        private void Telnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CheckTelnumber_Click(sender, e);
            }
        }

        private void Sum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Change();
            }
        }
    }
}
