using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProductivityTools.MoveDisplay.UI.Dialog
{
    public class DialogService : IDialogService
    {
        public void MoreThanTwoDisplaysMessage()
        {
            string message = (string)Application.Current.FindResource("MoreThanOneDisplay");
            Showmessage(message);
        }

        public void NoDisplayDetected()
        {
            string message = (string)Application.Current.FindResource("NoDisplay");
            Showmessage(message);
        }

        public void OneDisplayMessage()
        {
            string message = (string)Application.Current.FindResource("OnlyOneDisplay");
            Showmessage(message);
        }

        private void Showmessage(string s)
        {
            string title = (string)Application.Current.FindResource("MoveDisplay");
            MessageBox.Show(s, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
