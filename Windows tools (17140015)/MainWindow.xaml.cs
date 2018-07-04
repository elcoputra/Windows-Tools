using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Windows_tools__17140015_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            blink();
            
        }
        // convert dari color(FromArgb) ke brush
        SolidColorBrush brushDE = new SolidColorBrush(Color.FromArgb(255, 60, 34, 73));
        SolidColorBrush brushIP = new SolidColorBrush(Color.FromArgb(255, 253, 122, 31));
        SolidColorBrush brushCus = new SolidColorBrush(Color.FromArgb(255, 248, 207, 99));
        SolidColorBrush brushMed = new SolidColorBrush(Color.FromArgb(255, 42, 210, 187));
        SolidColorBrush brushShut = new SolidColorBrush(Color.FromArgb(255, 220, 4, 77));
        SolidColorBrush brushBl = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));


       


        private void btIP_Click(object sender, RoutedEventArgs e)
        {
            // ganti warna
            btIP.Background = brushIP;
            btIP.BorderBrush = brushIP;
            pan1.Background = brushIP;
            pan2.Background = brushIP;

            // reset warna yang lain
            btCus.Background = brushDE;
            btCus.BorderBrush = brushDE;
            btMed.Background = brushDE;
            btMed.BorderBrush = brushDE;
            btShut.Background = brushDE;
            btShut.BorderBrush = brushDE;
            // menampilkan tulisan bar atas
            txt1.Text = "Info And Change IP";
            frame1.NavigationService.RemoveBackEntry();

            //menampilkan pengolahan data
            frame1.Content = new ipSect();
            

        }

        private void btCus_Click(object sender, RoutedEventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.A))
            {
                MessageBox.Show("Hai ayu cantik");
            }
                //
            btCus.Background = brushCus;
            btCus.BorderBrush = brushCus;
            pan1.Background = brushCus;
            pan2.Background = brushCus;
            //
            btIP.Background = brushDE;
            btIP.BorderBrush = brushDE;
            btMed.Background = brushDE;
            btMed.BorderBrush = brushDE;
            btShut.Background = brushDE;
            btShut.BorderBrush = brushDE;
            frame1.NavigationService.RemoveBackEntry();

            txt1.Text = "Change Desktop Background And Login Background";

            //
            frame1.Content = new cusSect();
        }

        private void btMed_Click(object sender, RoutedEventArgs e)
        {
            //
            btMed.Background = brushMed;
            btMed.BorderBrush = brushMed;
            pan1.Background = brushMed;
            pan2.Background = brushMed;
            //
            btIP.Background = brushDE;
            btIP.BorderBrush = brushDE;
            btCus.Background = brushDE;
            btCus.BorderBrush = brushDE;
            btShut.Background = brushDE;
            btShut.BorderBrush = brushDE;

            txt1.Text = "Play mp3 and videos";
            frame1.NavigationService.RemoveBackEntry();

            //
            frame1.Content = new medSect();
        }

        private void btShut_Click(object sender, RoutedEventArgs e)
        {
            //
            btShut.Background = brushShut;
            btShut.BorderBrush = brushShut;
            pan1.Background = brushShut;
            pan2.Background = brushShut;
            //
            btIP.Background = brushDE;
            btIP.BorderBrush = brushDE;
            btCus.Background = brushDE;
            btCus.BorderBrush = brushDE;
            btMed.Background = brushDE;
            btMed.BorderBrush = brushDE;

            txt1.Text = "suhtdown pc with timer";
            frame1.NavigationService.RemoveBackEntry();
            //
            frame1.Content = new shutSect();
        }

        public async void blink()
        {
            int number = 1;
            do
            {
                elco.Foreground = brushShut;
            await Task.Delay(800);
            elco.Foreground = brushDE;
            await Task.Delay(800);
            elco.Foreground = brushMed;
            await Task.Delay(800);
            elco.Foreground = brushIP;
            await Task.Delay(800);
                number = number + 1;
            } while (number < 100);
        }

        private void frame1_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
