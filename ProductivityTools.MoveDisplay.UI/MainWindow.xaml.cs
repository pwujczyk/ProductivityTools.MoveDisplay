﻿using System;
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
            if (displays.Count > 1)
            {
                displays.MoveExternalDisplayToLeft();
            }
            else
            {
                MessageBox.Show("No external display detected. Nothing to move.");
            }
        }

        private void MoveRight_Click(object sender, RoutedEventArgs e)
        {

            ProductivityTools.UnmanagedDisplayWrapper.Displays displays = new UnmanagedDisplayWrapper.Displays();
            if (displays.Count > 1)
            {
                displays.MoveExternalDisplayToRight();
            }
            else
            {
                MessageBox.Show("No external display detected. Nothing to move.");
            }
        }
    }
}
