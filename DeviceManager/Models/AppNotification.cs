using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    public class Notification
    {
        public string Message { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public NotificationType Type { get; set; }

        public Notification(string message, DateTime dateTimeStamp, NotificationType type)
        {
            Message = message;
            DateTimeStamp = dateTimeStamp;
            Type = type;
        }
    }

    public enum NotificationType
    {
        Information,
        Warning,
        Error
    }
}
