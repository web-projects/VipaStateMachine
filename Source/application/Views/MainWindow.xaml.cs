using helpers;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Verifone;
using Verifone.VIPA.Processing;
using XO.Requests;

namespace VipaStateMachine.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VerifoneDevice verifoneDevice;

        public MainWindow()
        {
            InitializeComponent();

            verifoneDevice = new VerifoneDevice();
        }

        public async void OnCommandRequest(object sender, EventArgs e)
        {
            if (Enum.TryParse(CommandRequested.SelectedItem.ToString(), out Requests request))
            {
                Debug.WriteLine($"application: command request={request}");
                ProcessingResult processingResult = await verifoneDevice.ProcessRequest(request);
                commandResponse.Text = StringValueAttribute.GetStringValue(processingResult);
            }
        }

        public void OnCommandCancel(object sender, EventArgs e) 
        {
            
        }
    }
}