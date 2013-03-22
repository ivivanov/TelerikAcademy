using System;
using System.Windows;
using SideshowBobUI.ViewModel;

namespace SideshowBobUI.View
{
    /// <summary>
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        public void EmployeesClick(object sender, RoutedEventArgs e)
        {
            Employees view = new Employees();
            EmployeesViewModel viewModel = new EmployeesViewModel();
            view.DataContext = viewModel;
            view.ShowDialog();
        }

        public void ClientsClick(object sender, RoutedEventArgs e)
        {
            Clients view = new Clients();
            ClientsViewModel viewModel = new ClientsViewModel();
            view.DataContext = viewModel;
            view.ShowDialog();
        }

        public void VehiclesClick(object sender, RoutedEventArgs e)
        {
            Vehicles view = new Vehicles();
            VehiclesViewModel viewModel = new VehiclesViewModel();
            view.DataContext = viewModel;
            view.ShowDialog();
        }

        public void DealerClick(object sender, RoutedEventArgs e)
        {
            Dealer view = new Dealer();
            DealerViewModel viewModel = new DealerViewModel();
            view.DataContext = viewModel;
            view.ShowDialog();
        }
    }
}
