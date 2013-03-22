using SideshowBob;
using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SideshowBobUI.View
{
    /// <summary>
    /// Interaction logic for Vehicles.xaml
    /// </summary>
    public partial class Vehicles : Window
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        public void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            switch (CategoryTB.Text.ToString())
            {
                case ("Limosine"):
                    string color = ColorTB.Text;
                    int wheels = int.Parse(WheelsTB.Text);
                    Model model = (Model)Enum.Parse(typeof(Model), ModelTB.SelectedValue.ToString());
                    DateTime date = DateP.SelectedDate.Value;
                    decimal price = decimal.Parse(PriceTB.Text);
                    double speed = double.Parse(SpeedTB.Text);
                    AuthorisedDealer.Instance.Vehicles.Add(new Limosine(color, wheels, model, date, price, true, false, speed));
                    break;
                case ("Motorcycle"):
                    break;
                case ("SUV"):
                    break;
                case ("Truck"):
                    break;
                case ("Van"):
                    break;
            }
        }
    }
}
