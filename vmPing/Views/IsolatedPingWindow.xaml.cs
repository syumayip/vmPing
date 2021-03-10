﻿using System.Windows;
using System.Windows.Controls;
using vmPing.Classes;

namespace vmPing.Views
{
    /// <summary>
    /// Interaction logic for IsolatedPingWindow.xaml
    /// </summary>
    public partial class IsolatedPingWindow : Window
    {
        private int SelStart = 0;
        private int SelLength = 0;

        public IsolatedPingWindow(Probe pingItem)
        {
            InitializeComponent();
            pingItem.IsolatedWindow = this;
            DataContext = pingItem;
        }

        private void History_TextChanged(object sender, TextChangedEventArgs e)
        {
            History.SelectionStart = SelStart;
            History.SelectionLength = SelLength;
            History.ScrollToEnd();
        }

        private void History_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SelStart = History.SelectionStart;
            SelLength = History.SelectionLength;
        }
    }
}
