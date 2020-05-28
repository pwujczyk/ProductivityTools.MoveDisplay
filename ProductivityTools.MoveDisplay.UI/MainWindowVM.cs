using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.MoveDisplay.UI
{
    public class MainWindowVM
    {
        public ICommand MoveToLeftCommand { get; }
        public ICommand MoveToRightCommand { get; }

        public MainWindowVM()
        {
            MoveToLeftCommand = new CommandHandler(MoveToLeft, () => true);
            MoveToRightCommand = new CommandHandler(MoveToRight, () => true);
        }

        private void MoveToLeft()
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

        private void MoveToRight()
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
            //MessageBox.Show("Application is used to move external display to the left or right side of the screen. No external display detected. Nothing to move. If you want to use it please connect one external display to your pc/laptop and re-run application. I will work on the UI when application will start working correctly on all devices.");
        }
    }
}
