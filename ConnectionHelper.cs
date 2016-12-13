using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Pinger
{
    class ConnectionHelper
    {
        public PingReply PingIP(string address)
        {
            Ping pingSender = new Ping();
            PingReply pingReply = null;
            try
            {
                pingReply = pingSender.Send(address);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            /*
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine("Ping RoundTrip time: " + pingReply.RoundtripTime);
            }
             * */
            return pingReply;
        }
    }
}
