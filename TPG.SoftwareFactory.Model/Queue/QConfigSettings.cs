using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace TPG.SoftwareFactory.Model.Queue
{
    public class QConfigSettings : ConfigurationSection
    {
        private static QConfigSettings settings = ConfigurationManager.GetSection("QConfigSettings") as QConfigSettings;

        public static QConfigSettings Settings
        {
            get
            {
                return settings;
            }
        }

        #region Configuration


        //Retry Interval in milliseconds
        [ConfigurationProperty("retryInterval"
            , DefaultValue = 5000
            , IsRequired = false)]

        public int RetryInterval
        {
            get { return (int)this["retryInterval"]; }
            set { this["retryInterval"] = value; }
        }


        //Retry Count
        [ConfigurationProperty("maxRetryCount"
            , DefaultValue = 3
            , IsRequired = false)]

        public int MaxRetryCount
        {
            get { return (int)this["maxRetryCount"]; }
            set { this["maxRetryCount"] = value; }
        }


        //File Location
        [ConfigurationProperty("qFileLocation"
            , IsRequired = true)]
        public string QFileLocation
        {
            get { return (string)this["qFileLocation"]; }
            set { this["qFileLocation"] = value; }
        }

        //Failed File Location
        [ConfigurationProperty("qFailedFileLocation"
            , IsRequired = true)]
        public string QFailedFileLocation
        {
            get { return (string)this["qFailedFileLocation"]; }
            set { this["qFailedFileLocation"] = value; }
        }

        //Response Text
        //Retry Count
        [ConfigurationProperty("responseText"
            , DefaultValue = "Queued"
            , IsRequired = false)]

        public string ResponseText
        {
            get { return (string)this["responseText"]; }
            set { this["responseText"] = value; }
        }

        //Self hosting

        #endregion

    }
}
