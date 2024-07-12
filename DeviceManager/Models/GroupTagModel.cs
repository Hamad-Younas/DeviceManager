using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class GroupTagModel
    {
        [JsonProperty("@odata.count")]
        public int ODataCount { get; set; }

        [JsonProperty("value")]
        public List<grouptag> groupname { get; set; }
    }
    public class grouptag
    {
        public string azureAdDeviceId { get; set; } = "";
        public string groupTag { get; set; } = "";
    }
}
