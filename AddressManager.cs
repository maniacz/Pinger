using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Pinger
{
    class AddressManager
    {
        public List<string> GenerateAddressRange(string network, int startAddress, int endAddress)
        {
            List<string> addresList = new List<string>();
            for (int i = startAddress; i <= endAddress; i++)
            {
                string addressToAdd = network + '.' + i.ToString();
                addresList.Add(addressToAdd);
            }
            return addresList;
        }

        internal List<string> GenerateAddressPingList(string startAddress, string endAddress, List<string> notPingedAddresses)
        {
            List<string> addressesToPing = new List<string>();
            int start = Convert.ToInt32(startAddress.Substring(12));
            int end = Convert.ToInt32(endAddress.Substring(12));
            string network = startAddress.Substring(0, 11);
            for (int i = start; i <= end; i++)
            {
                string addressToAdd = network + "." + i;
                if (!notPingedAddresses.Contains(addressToAdd))
                    addressesToPing.Add(addressToAdd);
            }
            return addressesToPing;
        }
    }
}
