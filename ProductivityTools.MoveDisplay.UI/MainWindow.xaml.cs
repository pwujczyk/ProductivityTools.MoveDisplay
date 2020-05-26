using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductivityTools.MoveDisplay.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveLeft_Click(object sender, RoutedEventArgs e)
        {
            ProductivityTools.UnmanagedDisplayWrapper.Displays displays = new UnmanagedDisplayWrapper.Displays();
            displays.LoadData();
            if (displays.Count > 1)
            {
                displays.MoveExternalDisplayToLeft();
            }
            else
            {
                ShowMessage();
            }
        }

        private void MoveRight_Click(object sender, RoutedEventArgs e)
        {

            ProductivityTools.UnmanagedDisplayWrapper.Displays displays = new UnmanagedDisplayWrapper.Displays();
            displays.LoadData();
            if (displays.Count > 1)
            {
                displays.MoveExternalDisplayToRight();
            }
            else
            {
                ShowMessage();
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("Application is used to move external display to the left or right side of the screen. No external display detected. Nothing to move. If you want to use it please connect one external display to your pc/laptop and re-run application. I will work on the UI when application will start working correctly on all devices.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Information.Text = string.Empty;
            ProductivityTools.UnmanagedDisplayWrapper.Displays displays = new UnmanagedDisplayWrapper.Displays();
            displays.LoadData();
            foreach (var display in displays)
            {
                var dump = ObjectDumper.Dump(display);
                this.Information.Text += dump;
            }
        }
    }
}
