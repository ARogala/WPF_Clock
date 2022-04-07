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
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Settings clockSettings = new Settings();
        public MainWindow()
        {
            InitializeComponent();
            //start app in top right corner
            this.Top = 0;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width;
            //hide running app from taskbar
            this.ShowInTaskbar = false;

            DispatcherTimer timer = new DispatcherTimer(); 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
            SetDate();

           
            clockSettings.ColorChoice = "#FF3131";
            this.DataContext = clockSettings;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;  
            lblTime.Content = now.ToLongTimeString();
            //set date at midnight
            if(now.ToLongTimeString() == "12:00:00 AM")
            {
                SetDate();
            }     
        }

        private void SetDate()
        {
            DateTime now = DateTime.Now;
            lblDate.Content = now.ToLongDateString();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
        //window stuff
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            window.Close();
        }
    }
}
