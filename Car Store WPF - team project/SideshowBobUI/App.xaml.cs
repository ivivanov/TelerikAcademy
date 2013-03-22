using SideshowBobUI.View;
using System.Windows;

namespace SideshowBobUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private WelcomeScreen view;
        //private WelcomeScreenViewModel viewMode;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            view = new WelcomeScreen();
            //viewModel = new WelcomeScreenViewModel();
            //view.DataContext = viewModel;
            view.Show();
        }
    }
}
