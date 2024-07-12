using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class SupportModel
    {
        public string contactITName { get; set; } = "";
        public string displayName { get; set; } = "";
        public string contactITPhoneNumber { get; set; } = "";
        public string contactITEmailAddress { get; set; } = "";
        public string onlineSupportSiteUrl { get; set; } = "";
        public string onlineSupportSiteName { get; set; } = "";

        [JsonProperty("lightBackgroundLogo")]
        public ImageData lightBackgroundLogo;

        [JsonProperty("darkBackgroundLogo")]
        public ImageData darkBackgroundLogo;
    }
    public class ImageData
    {
        public string Type { get; set; } = "";
        public string Value { get; set; } = "";
    }
}
