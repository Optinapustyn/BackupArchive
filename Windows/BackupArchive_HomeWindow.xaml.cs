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
    public partial class BackupArchive_HomeWindow : Window
    {
        public BackupArchive_HomeWindow()
        {
            InitializeComponent();
        }

        private void Dashboard_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonUI(Dashboard_Button, Backup_Button, Recovery_Button, Settings_Button, Help_Button);
        }

        private void Backup_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonUI(Backup_Button, Dashboard_Button, Recovery_Button, Settings_Button, Help_Button);
        }

        private void Recovery_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonUI(Recovery_Button, Dashboard_Button, Backup_Button, Settings_Button, Help_Button);
        }

        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonUI(Settings_Button, Dashboard_Button, Backup_Button, Recovery_Button, Help_Button);
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonUI(Help_Button, Dashboard_Button, Backup_Button, Recovery_Button, Settings_Button);
        }

        private void ButtonUI(Button clickedButton, Button otherButton1, Button otherButton2, Button otherButton3, Button otherButton4)
        {
            #region COLOR CONFIGURATION
            // DARK BRUSH RGB
            byte darkR = 24;
            byte darkG = 30;
            byte darkB = 54;

            // LIGHT BRUSH RGB
            byte lightR = 46;
            byte lightG = 51;
            byte lightB = 73;

            // DARK INITIALIZER
            Color darkColor = Color.FromArgb(255, darkR, darkG, darkB);

            // LIGHT INITIALIZER
            Color lightColor = Color.FromArgb(255, lightR, lightG, lightB);

            // DARK BRUSH INITIALIZER
            SolidColorBrush darkBrush = new SolidColorBrush(darkColor);

            // LIGHT BRUSH INITIALIZER
            SolidColorBrush lightBrush = new SolidColorBrush(lightColor);
            #endregion

            #region BUTTON BACKGROUND-COLOR CHANGE
            // CLICKED BUTTON
            clickedButton.Background = lightBrush;

            // OTHER BUTTONS
            otherButton1.Background = darkBrush;
            otherButton2.Background = darkBrush;
            otherButton3.Background = darkBrush;
            otherButton4.Background = darkBrush;
            #endregion
        }
    }
}
