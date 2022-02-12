using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BackupArchive.Windows
{
    public partial class BackupArchive_AwakeWindow : Window
    {
        public BackupArchive_AwakeWindow()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            BackupArchive_HomeWindow backupArchive_HomeWindow = new BackupArchive_HomeWindow();
            backupArchive_HomeWindow.Show();
            this.Hide();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
