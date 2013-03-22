using SideshowBob;
using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;
using System;
using System.Windows;

namespace SideshowBobUI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dealer : Window
    {
        public Dealer()
        {
            InitializeComponent();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            AuthorisedDealer.Instance.SettingUpAuthorisedDealer(NameTB.Text, StreetTB.Text, StreetTB.Text, StateTB.Text,PhoneTB.Text);
            InfoTB.Text = AuthorisedDealer.Instance.ToString();
        }

       
    }
}
