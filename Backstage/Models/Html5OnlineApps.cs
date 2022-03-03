using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Html5OnlineApps
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
