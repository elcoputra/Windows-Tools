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
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;
using System.Management;

namespace Windows_tools__17140015_
{
    /// <summary>
    /// Interaction logic for ipSect.xaml
    /// </summary>
    public partial class ipSect : Page
    {

        // pertama di exekusi
        public ipSect()
        {
            InitializeComponent();
            infoip_();// metod tampilin local IP
            var obj = new Adapters();
            var values = obj.net_adapters();
            listBox1.ItemsSource = values;

        }

        // nyari IP local
        private void infoip_()//local ip
        {
            IPHostEntry iph;
            string myip = "";
            iph = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in iph.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myip = ip.ToString();
                    txtIP.Text = myip.ToString();
                }
            }
        }

        public static string infoPub_()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        private void btnRefInfo_Click(object sender, RoutedEventArgs e)
        {
            infoip_();
        }
        private void btnIP_pub_Click(object sender, RoutedEventArgs e)
        {

            txtIP_pub.Text = infoPub_();
        }


        public void SetIP(string ipAddress, string subnetMask, string gateway)
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                    {
                        using (var newIP = managementObject.GetMethodParameters("EnableStatic"))
                        {
                            // Set new IP address and subnet if needed
                            if ((!String.IsNullOrEmpty(ipAddress)) || (!String.IsNullOrEmpty(subnetMask)))
                            {
                                if (!String.IsNullOrEmpty(ipAddress))
                                {
                                    newIP["IPAddress"] = new[] { ipAddress };
                                }

                                if (!String.IsNullOrEmpty(subnetMask))
                                {
                                    newIP["SubnetMask"] = new[] { subnetMask };
                                }

                                managementObject.InvokeMethod("EnableStatic", newIP, null);
                            }

                            // Set mew gateway if needed
                            if (!String.IsNullOrEmpty(gateway))
                            {
                                using (var newGateway = managementObject.GetMethodParameters("SetGateways"))
                                {
                                    newGateway["DefaultIPGateway"] = new[] { gateway };
                                    newGateway["GatewayCostMetric"] = new[] { 1 };
                                    managementObject.InvokeMethod("SetGateways", newGateway, null);
                                }
                            }
                        }
                    }
                }
            }
        }


        public void setDNS(string NIC, string DNS)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    // if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                    if (objMO["Caption"].Equals(NIC))
                    {
                        try
                        {
                            ManagementBaseObject newDNS =
                                objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                            ManagementBaseObject setDNS =
                                objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }


        private void btn_clearForm_Click(object sender, RoutedEventArgs e)
        {
            // clear teks di textblock
            boxIP.Text = "";
            boxGate.Text = "";
            boxSubnet.Text = "";
        }

        private void btn_setIP_Click(object sender, RoutedEventArgs e)
        {

            //(string ipAddress, string subnetMask, string gateway)SetIP

            string ipAddress = boxIP.Text;
            string subnetMask = boxSubnet.Text;
            string gateway = boxGate.Text;
            SetIP(ipAddress, subnetMask, gateway);

            if (!string.IsNullOrWhiteSpace(ipAddress) & !string.IsNullOrWhiteSpace(subnetMask) & !string.IsNullOrWhiteSpace(gateway))
            {
                MessageBox.Show("IP, Subnet, Dan Gateway berhasil di ganti");
            }
            else if (!string.IsNullOrWhiteSpace(ipAddress))
            {
                MessageBox.Show("IP berhasil di ganti");
            }
            else if (!string.IsNullOrWhiteSpace(subnetMask))
            {
                MessageBox.Show("Subnet berhasil di ganti");
            }
            else if (!string.IsNullOrWhiteSpace(gateway))
            {
                MessageBox.Show("Gateway berhasil di ganti");
            }
            else
            {
                MessageBox.Show("Tidak ada yang di rubah, cek kembali field yang harus di isi");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Check publik IP harus terkoneksi dengan internet");
        }

        private void helpIP_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A  |10.0.0.0                     (10.0.0.0 - 10.255.255.255)" + "\n" +
                            "B  |172.16.0.0 - 172.31.0.0 (172.16.0.0 - 172.31.255.255)" + "\n" +
                            "C  |192.168.0.0               (192.168.0.0 - 192.168.255.255)");
        }


        // Bagian DHCP

        public class Adapters
        {
            public IEnumerable<String> net_adapters()
            {
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    yield return nic.Name;
                }
                yield break;
            }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            texPilihan.Text = listBox1.SelectedItem.ToString();
        }

        private void setDHCP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ManagementObject classInstance =
                    new ManagementObject("root\\CIMV2",
                    "Win32_NetworkAdapterConfiguration.Index='1'",
                    null);

                // no method in-parameters to define


                // Execute the method and obtain the return values.
                ManagementBaseObject outParams =
                    classInstance.InvokeMethod("EnableDHCP", null, null);

                // List outParams
                MessageBox.Show("Network saat ini sudah ter-setting DHCP");
            }
            catch (ManagementException err)
            {
                MessageBox.Show("An error occurred while trying to execute the WMI method: " + err.Message);
            }
        }



        // Bagian DNS

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            //salah!  string[] searchDns = boxDNS.Text.Split(Environment.NewLine);

            //static!  string[] searchDns = { "8.8.4.4", "8.8.8.8" };

            string[] searchDns = boxDNS.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);

            if (string.IsNullOrEmpty(boxDNS.Text))
            {
                MessageBox.Show("Silahkan masukan DNS !");
            }
            else
            {
                try
                {
                    ManagementClass classInstance =
                        new ManagementClass("root\\CIMV2",
                        "Win32_NetworkAdapterConfiguration", null);

                    // Obtain in-parameters for the method
                    ManagementBaseObject inParams =
                        classInstance.GetMethodParameters("EnableDNS");

                    // Add the input parameters.
                    inParams["DNSServerSearchOrder"] = searchDns;

                    // Execute the method and obtain the return values.
                    ManagementBaseObject outParams =
                        classInstance.InvokeMethod("EnableDNS", inParams, null);

                    // List outParams
                    Console.WriteLine("Out parameters:");
                    Console.WriteLine("ReturnValue: " + outParams["ReturnValue"]);
                }
                catch (ManagementException err)
                {
                    string aa;

                    MessageBox.Show("An error occurred while trying to execute the WMI method: " + err.Message);
                }

                MessageBox.Show("eeeew");
            }
            
        }

    }
}
