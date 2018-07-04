using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;

namespace Windows_tools__17140015_
{
    /// <summary>
    /// Interaction logic for cusSect.xaml
    /// </summary>
    public partial class cusSect : Page
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)] //memasukan dll user profile
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        /*
        int iCount = 0; //global counter for hiding/closing form after certian period of inactivity
        byte[] bLevels; //array of valid level values
        string[] arguments;
        */

        public cusSect()
        {
           // double aa;
           

            InitializeComponent();

            


        }

        private void btnPilih_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // filter untuk file
            dlg.DefaultExt = ".png";
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";


            // menampilkan expoler untuk memilih file
            Nullable<bool> result = dlg.ShowDialog();


            // memasukan nama file ke textbook
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                txt1.Text = filename;
            }
        }

        private void btnGanti_Click(object sender, RoutedEventArgs e)
        {
            int nResult;
            if (File.Exists(txt1.Text))
            {
                nResult = cusSect.SystemParametersInfo(20, 0, txt1.Text, 0x1 | 0x2);
                MessageBox.Show("Wallpaper has been changed");
            }
        }



        // brightnes (kecerahan layar)
        //info brightnes dari WMI
        public void infoBright()
        {
            
            
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM WmiMonitorBrightness");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    bNow.Text = (queryObj["CurrentBrightness"].ToString());
                    
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        }

        // set WMI brightnes
        static void SetBrightness(byte targetBrightness)
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        mObj.InvokeMethod("WmiSetBrightness",
                            new Object[] { UInt32.MaxValue, targetBrightness });
                        break;
                    }
                }
            }
        }

        //slider posisi sesuai brightnes saaat ini

            public void slidePosPersen()
        {
            
            string valueB;
            string valueB1;
            double valueB2;


            infoBright();
            valueB = bNow.Text;
            valueB1 = Regex.Match(valueB, @"\d+").Value;
            valueB2 = System.Convert.ToDouble(valueB1);
            
            bSlide.Value = valueB2;
            
            
        }

        private void b20_Click(object sender, RoutedEventArgs e)
        {
            byte targetBrightness = 20;
            SetBrightness(targetBrightness);
            //bNow.Text = (System.Convert.ToString(targetBrightness));
            infoBright();
            slidePosPersen();
        }

        private void b40_Click(object sender, RoutedEventArgs e)
        {
            byte targetBrightness = 40;
            SetBrightness(targetBrightness);
            //bNow.Text = (System.Convert.ToString(targetBrightness));
            infoBright();
            slidePosPersen();
        }

        private void b60_Click(object sender, RoutedEventArgs e)
        {
            byte targetBrightness = 60;
            SetBrightness(targetBrightness);
            //bNow.Text = (System.Convert.ToString(targetBrightness));
            infoBright();
            slidePosPersen();
        }

        private void b80_Click(object sender, RoutedEventArgs e)
        {
            byte targetBrightness = 80;
            SetBrightness(targetBrightness);
            //bNow.Text = (System.Convert.ToString(targetBrightness));
            infoBright();
            slidePosPersen();
        }

        private void b100_Click(object sender, RoutedEventArgs e)
        {
            byte targetBrightness = 100;
            SetBrightness(targetBrightness);
            //bNow.Text = (System.Convert.ToString(targetBrightness));
            infoBright();
            slidePosPersen();
        }

        private void bSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

         
            //string a;
            byte targetBrightness;
            double b = bSlide.Value;
            targetBrightness = System.Convert.ToByte(b);
            SetBrightness(targetBrightness);

            //string aaa;
            //bnow.Text = System.Convert.ToString(bSlide.Value);
            //slidePosPersen();
            //bNow.Text = e.NewValue.ToString();
          
        }

        private void coba_Click(object sender, RoutedEventArgs e)
        {
            int nResult;
            if (File.Exists(txt1.Text))
            {
                nResult = cusSect.SystemParametersInfo(20, 0, txt1.Text, 0x1 | 0x2);
                MessageBox.Show("Wallpaper has been changed");
            }
        }
    }
}

