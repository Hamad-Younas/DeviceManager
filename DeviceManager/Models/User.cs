using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class User
    {
        public string givenName { get; set; } = "";
        public string displayName { get; set; } = "";
        public string id { get; set; } = "";
        public string signInSessionsValidFromDateTime { get; set; } = "";
        public string jobTitle { get; set; } = "";
        public string employeeId { get; set; } = "";
        public string officeLocation { get; set; } = "";
        public string mail { get; set; } = "";
        public string mobilePhone { get; set; } = "";
        public string onPremisesSamAccountName { get; set; } = "";
        public string employeeType { get; set; } = "";
        public string onPremisesSecurityIdentifier { get; set; } = "";
    }
}
