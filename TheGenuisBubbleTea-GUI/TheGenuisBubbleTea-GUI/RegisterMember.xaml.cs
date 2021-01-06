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
    /// Interaction logic for RegisterMember.xaml
    /// </summary>
    public partial class RegisterMember : Window
    {
        public RegisterMember()
        {
            InitializeComponent();
        }
        private void registerButton_Click(object sender, RoutedEventArgs e)
        { 

            if (nameBox.Text != "" && surnameBox.Text != "" && telNumberEntity.Text != "")
            {
                string todayDate = DateTime.Today.ToString("dd/MM/yyyy");
                Member register = new Member(nameBox.Text, surnameBox.Text, telNumberEntity.Text, todayDate);

                if (register.CheckMember(telNumberEntity.Text) == false)
                {
                    if (register.RegisterMember())
                    {
                        if(MessageBox.Show("Register Complete", "Status", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This Member has already registed", "Status", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Enter fill properly member data", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            telNumberEntity.Text = "";
        }
    }
}
