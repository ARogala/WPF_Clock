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
        public MainWindow()
        {
            InitializeComponent();
            //start app in top right corner
            this.Top = 0;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width;
            //hide running app from taskbar
            this.ShowInTaskbar = false;

            DispatcherTimer timer = new DispatcherTimer(); 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            window.Close();
        }
        //window stuff
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            window.Close();
        }  
    }
}
