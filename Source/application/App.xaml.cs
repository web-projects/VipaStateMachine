using System.Windows;
using VipaStateMachine.Views;

namespace VipaStateMachine
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
