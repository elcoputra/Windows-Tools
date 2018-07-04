using Microsoft.Win32;
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

namespace Windows_tools__17140015_
{
    /// <summary>
    /// Interaction logic for medSect.xaml
    /// </summary>
    public partial class medSect : Page
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public medSect()
        {
            InitializeComponent();
            MainkanVideo(false);

        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
                lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void btnAddMusic_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                mediaPlayer.Open(new Uri(openFileDialog.FileName));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        ///////// Video section /////////

        private void MainkanVideo(bool flag)
        {
            playVid.IsEnabled = flag;
            stopVid.IsEnabled = flag;
            backVid.IsEnabled = flag;
            forVid.IsEnabled = flag;
        }

        /* Not workong
        void timer_Tick2(object sender, EventArgs e)
        {
            if (playerBox.Source != null)
                lblVideo.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblVideo.Content = "No file selected...";
        }

        
        */

        private void playVid_Click(object sender, RoutedEventArgs e)
        {
            MainkanVideo(true);
            if (playVid.Content.ToString() == "Play")
            {
                playerBox.Play();
                playVid.Content = "Pause";
            }
            else
            {
                playerBox.Pause();
                playVid.Content = "Play";
            }
           


        }

        private void stopVid_Click(object sender, RoutedEventArgs e)
        {
            playerBox.Stop();
            playVid.Content = "Play";
            MainkanVideo(false);
            playVid.IsEnabled = true;
        }

        private void backVid_Click(object sender, RoutedEventArgs e)
        {
            playerBox.Position -= TimeSpan.FromSeconds(10);
        }

        private void forVid_Click(object sender, RoutedEventArgs e)
        {
            playerBox.Position += TimeSpan.FromSeconds(10);
        }

        private void openVid_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Pilih video";
            dialog.DefaultExt = ".MP4";
            dialog.Filter = "MP4 file (.mp4) | *.mp4 |WMV file (.wm) | *.wmv |Semua format (*.*)|*.*";

            //mengeluarkan dialog
            Nullable<bool> result = dialog.ShowDialog();

            //memperoses box dialog
            if (result == true)
            {
                //buka file
                playerBox.Source = new Uri(dialog.FileName);
                playVid.IsEnabled = true;


                
            }
            /* Not working
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick2;
            timer.Start();
            */
        }
    }
}
