using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class AppDevice
    {
        public AppDevice()
        {

        }

        public string username { get; set; } = "N/A";
        public string upn { get; set; } = "N/A";
        public string hostname { get; set; } = "N/A";
        public string ip { get; set; } = "N/A";
        public string assetTag { get; set; } = "N/A";
        public string serialNumber { get; set; } = "N/A";
        public string assetStatus { get; set; } = "N/A";
        public string primaryUser { get; set; } = "N/A";
    }
}
