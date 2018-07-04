using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.InteropServices;

namespace Windows_tools__17140015_
{
    /// <summary>
    /// Interaction logic for shutSect.xaml
    /// </summary>
    public partial class shutSect : Page
    {

        public static string todo;
        public static int timeLeft;
        public static int hour;
        public static int min;
        public static int sec;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint Flags, uint Reason);
        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public shutSect()
        {

            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }


        private void Shutdown_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "Mengclose semua apikasi, dan mematikan windows.";
            todo = "shutdown";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;


        }
        private void Shutdownf_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "Mengclose semua apikasi, dan mematikan windows Paksa.";
            todo = "shutdownf";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }
        private void Shutdownt_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "Mengclose semua apikasi, dan mematikan windows dengan waktu.";
            todo = "shutdownt";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = true;
            Xtimer.IsEnabled = false;
        }
        private void restart_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "Mengclose semua apikasi,dan merestart";
            todo = "restart";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }
        private void sleep_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "The PC stays on but uses low power. Apps stays open so when the " + Environment.NewLine + "PC waked up, you're instantly back to when you left off.";
            todo = "sleep";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }
        private void signout_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "Closes all apps and signs you out.";
            todo = "signout";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }
        private void hibernate_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "The PC stays Off . Apps saves on hardisk so when the PC waked up," + Environment.NewLine + " you're back to when you left off.";
            todo = "hibernate";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }
        private void lock_Selected(object sender, RoutedEventArgs e)
        {
            info.Content = "The PC stays on and lock your Pc.";
            todo = "lock";
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = Xtimer.IsEnabled = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
             if (todo.Equals("shutdown"))
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else if (todo.Equals("shutdownf"))
            {
                Process.Start("shutdown", "/s /f /t 0");
            }
            else if (todo.Equals("shutdownt"))
            {
                try
                {
                    hour = Int16.Parse(hh.Text);
                    min = Int16.Parse(mm.Text);
                    sec = Int16.Parse(ss.Text);
                    timeLeft = hour * 3600 + min * 60 + sec;
                    timer.Start();
                    options.IsEnabled = false;
                    Xtimer.IsEnabled = true;
                }
                catch
                {
                    MessageBox.Show("Time format is incorrect!", "ERROR");
                }
            }
            else if (todo.Equals("restart"))
            {
                Process.Start("shutdown", "/r /t 0");
            }
            else if (todo.Equals("sleep"))
            {
                SetSuspendState(false, true, true);
            }
            else if (todo.Equals("signout"))
            {
                ExitWindowsEx(0, 0);
            }
            else if (todo.Equals("hibernate"))
            {
                SetSuspendState(true, true, true);
            }
            else if (todo.Equals("lock"))
            {
                LockWorkStation();
            }
            else
            {
                MessageBox.Show("Unhandled Exception");
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                hour = timeLeft / 3600;
                min = (timeLeft - (hour * 3600)) / 60;
                sec = timeLeft - (hour * 3600) - (min * 60);
                hh.Text = hour.ToString();
                mm.Text = min.ToString();
                ss.Text = sec.ToString();
                hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = false;

            }
            else
            {
                timer.Stop();
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            options.IsEnabled = true;
            hh.IsEnabled = ss.IsEnabled = mm.IsEnabled = true;
        }

        private void options_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Xtimer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}