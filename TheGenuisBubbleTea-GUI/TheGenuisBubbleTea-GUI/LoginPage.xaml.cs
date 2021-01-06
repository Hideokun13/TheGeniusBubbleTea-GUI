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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLogin(usernameEntity.Text, passwordEntity.Password))
            {
                HomePage home = new HomePage();
                home.Show();
                this.Close();
                MessageBox.Show("Welcome to the the Genius Bubble Tea Program!", "Login Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("กรุณาใส่ Username และ Password ให้ถูกต้อง", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private bool CheckLogin (string username, string password)
        {
            bool isMatch = false;

            FileManagement file = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Login/Login.txt");
            List<string> loginAcc = new List<string>();
            foreach(string i in file.ReadFile())
            {
                if (i != "")
                {
                    string[] acc = new string[2];
                    acc = i.Split(",");
                    string user = acc[0];
                    string pass = acc[1];
                    if (user == username && pass == password)
                    {
                        return isMatch = true;
                    }
                }
            }
            return isMatch;
        }
        private void passwordEntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
