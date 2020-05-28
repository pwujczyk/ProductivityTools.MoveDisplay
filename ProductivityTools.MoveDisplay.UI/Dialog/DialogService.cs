using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProductivityTools.MoveDisplay.UI.Dialog
{
    public class DialogService : IDialogService
    {
        public void ShowOneDisplayMessage()
        {
            MessageBox.Show("Application is used to move external display to the left or right side of the screen. No external display detected. Nothing to move. If you want to use it please connect one external display to your pc/laptop and re-run application. I will work on the UI when application will start working correctly on all devices.");
        }
    }
}
