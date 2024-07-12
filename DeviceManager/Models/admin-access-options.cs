using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Models
{
    using System;

    public enum TimeOptions
    {
        [ExpiryFormat("1 day - Exp {0}")]
        Option1 = 1,

        [ExpiryFormat("2 day - Exp {0}")]
        Option2 = 2,

        [ExpiryFormat("3 day - Exp {0}")]
        Option3 = 3,
        
        [ExpiryFormat("4 day - Exp {0}")]
        Option4=4,

        [ExpiryFormat("5 day - Exp {0}")]
        Option5 = 5,

    }

    public class ExpiryFormatAttribute : Attribute
    {
        public string Format { get; }

        public ExpiryFormatAttribute(string format)
        {
            Format = format;
        }
    }

    public static class TimeOptionsExtensions
    {
        public static string ToFormattedString(this TimeOptions option)
        {
            var attribute = option.GetType()
                                 .GetField(option.ToString())
                                 .GetCustomAttributes(typeof(ExpiryFormatAttribute), false)
                                 .FirstOrDefault() as ExpiryFormatAttribute;

            DateTime calculatedDate;

            // Calculate the date based on the selected option
            switch (option)
            {
                case TimeOptions.Option1:
                    calculatedDate = DateTime.Now.AddDays(1);
                    break;

                case TimeOptions.Option2:
                    calculatedDate = DateTime.Now.AddDays(2);
                    break;

                case TimeOptions.Option3:
                    calculatedDate = DateTime.Now.AddDays(3);
                    break;

                case TimeOptions.Option4:
                    calculatedDate = DateTime.Now.AddDays(4);
                    break;

                case TimeOptions.Option5:
                    calculatedDate = DateTime.Now.AddDays(5);
                    break;
                default:
                    calculatedDate = DateTime.Now;
                    break;
            }


            return attribute != null ? string.Format(attribute.Format, calculatedDate.ToString("MM/dd/yy")) : option.ToString();
        }

    }


}
