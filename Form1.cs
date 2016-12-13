using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;

namespace Pinger
{
    public partial class Form1 : Form
    {
        ConnectionHelper connection = new ConnectionHelper();
        AddressManager addresses = new AddressManager();

        public Form1()
        {
            InitializeComponent();
            //mtbxStartIP.Mask = "###.###.###.###";
            mtbxStartIP.ValidatingType = typeof(System.Net.IPAddress);
            //connection.PingIP("149.223.243.72");
            connection.PingIP(mtbxStartIP.Text);
        }

        private void mtbxStartIP_TextChanged(object sender, EventArgs e)
        {
            string startIp = (sender as MaskedTextBox).Text;
            mtbxEndIP.Text = startIp.Substring(0, 11);
            mtbxEndIP.Refresh();
        }

        private void mtbxEndIP_Leave(object sender, EventArgs e)
        {
            int startIpLastOctet = Int32.Parse(mtbxStartIP.Text.Substring(12));
            int endIpLastOctet = Int32.Parse(mtbxEndIP.Text.Substring(12));
            if (startIpLastOctet >= endIpLastOctet)
            {
                MessageBox.Show("Start IP cannot be higher than End IP");
                mtbxEndIP.Text = mtbxStartIP.Text;
            }
        }

        private void cbxExclude_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxExclude.Checked)
                return;
            string network = mtbxStartIP.Text.Substring(0, 11);
            int startIp = Int32.Parse(mtbxStartIP.Text.Substring(12));
            int endIp = Int32.Parse(mtbxEndIP.Text.Substring(12));
            List<string> addressRange = addresses.GenerateAddressRange(network, startIp, endIp);
            clbxExcludedIPs.Items.Clear();
            int i = 0;
            foreach (string address in addressRange)
            {
                clbxExcludedIPs.Items.Add(address);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread pingsThread = new Thread(new ThreadStart(this.RunPings));
            pingsThread.Start();
            //RunPings();
        }

        private void RunPings()
        {
            string fromIP = mtbxStartIP.Text;
            string toIP = mtbxEndIP.Text;
            List<string> except = new List<string>();
            foreach (string checkedIP in clbxExcludedIPs.CheckedItems)
            {
                except.Add(checkedIP);
            }
            List<string> addressesToPing = addresses.GenerateAddressPingList(fromIP, toIP, except);

            PingReply pingReply;
            //Thread pingThread = new Thread(new ParameterizedThreadStart(connection.PingIP));
            foreach (string ip in addressesToPing)
            {
                pingReply = connection.PingIP(ip);
                tbxPingReport.Text += string.Format("{0} Pinging: {1} Status: {2}", DateTime.Now, ip, pingReply.Status.ToString() + Environment.NewLine);
            }
        }
    }
}
