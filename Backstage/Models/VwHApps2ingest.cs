using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwHApps2ingest
    {
        public long ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public bool IngestionStatus { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
