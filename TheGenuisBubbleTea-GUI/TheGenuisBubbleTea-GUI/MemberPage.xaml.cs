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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Window
    {
        public MemberPage()
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

        private void OrderStatusButton_Click(object sender, RoutedEventArgs e)
        {
            OrderStatusPage orderStatus = new OrderStatusPage();
            orderStatus.Show();
            this.Close();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            if (telNumberEntity.Text != "")
            {
                Member checkMember = new Member(nameBox.Text, surnameBox.Text, telNumberEntity.Text, DateTime.Today.ToString("dd/MM/yyyy"));

                if (checkMember.CheckMember(telNumberEntity.Text))
                {
                    List<string> memInfo = new List<string>();
                    memInfo.Add(checkMember.PrintMemberInfo(telNumberEntity.Text));
                    foreach (string i in memInfo)
                    {
                        string[] temp = new string[4];
                        temp = i.Split(",");
                        string name = temp[0];
                        string surname = temp[1];
                        string telNumber = temp[2];
                        string registerDate = temp[3];

                        nameBox.Text = name;
                        surnameBox.Text = surname;
                        registerDateBox.Text = registerDate;

                        nameStack.Visibility = Visibility.Visible;
                        surnameStack.Visibility = Visibility.Visible;
                        registerStack.Visibility = Visibility.Visible;
                        MessageBox.Show("This Member is " + name + " " + surname + "\nTelNumber: " + telNumber +"\nRegister Date: " + registerDate, "Status", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                }
                else
                {
                    if (MessageBox.Show("This Member hasn't register in system \nCreate New Member?", "Status", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        registerButton_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter fill properly member data", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterMember register = new RegisterMember();
            register.telNumberEntity.Text = telNumberEntity.Text;
            register.Show();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            telNumberEntity.Text = "";
            registerDateBox.Text = "";
            nameStack.Visibility = Visibility.Collapsed;
            surnameStack.Visibility = Visibility.Collapsed;
            registerStack.Visibility = Visibility.Collapsed;
        }
        
    }
}
