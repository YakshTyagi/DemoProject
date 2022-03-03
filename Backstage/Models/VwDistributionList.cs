using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwDistributionList
    {
        public string Itvid { get; set; }
        public string AppName { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }
    }
}
