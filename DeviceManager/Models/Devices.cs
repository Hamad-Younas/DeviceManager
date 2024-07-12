using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class DeviceInformation
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("@odata.count")]
        public int ODataCount { get; set; }

        [JsonProperty("value")]
        public List<Devices> devices { get; set; }
    }

    public class Devices
    {
        public string deviceName { get; set; } = "";
        public string nickName { get; set; } = "";
        public string managementAgent { get; set; } = "";
        public string managedDeviceOwnerType { get; set; } = "";
        public string serialNumber { get; set; } = "";
        public string manufacturer { get; set; } = "";
        public string model { get; set; } = "";
        public string userPrincipalName { get; set; } = "";
        public string complianceState { get; set; } = "";
        public string lastSyncDateTime { get; set; } = "";
        public string deviceEnrollmentType { get; set; } = "";
        public string wiFiMacAddress { get; set; } = "";
        public string ethernetMacAddress { get; set; } = "";
        public string id { get; set; } = "";
        public string easDeviceId { get; set; } = "";
        public string azureADDeviceId { get; set; } = "";
        public string operatingSystem { get; set; } = "";
        public string osVersion { get; set; } = "";
        public string totalStorageSpaceInBytes { get; set; } = "";
        public string freeStorageSpaceInBytes { get; set; } = "";
        public string physicalMemoryInBytes { get; set; } = "";
        public string userDisplayName { get; set; } = "";
        public string managedDeviceName { get; set; } = "";
        public string groupTag { get; set; } = "";
        public string emailAddress { get; set; } = "";

    }
}
