using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Ischedule
    {
        public long IschId { get; set; }
        public long IappId { get; set; }
        public long BuildId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public DateTime? IngestionDatetime { get; set; }
        public DateTime? IngestedDatetime { get; set; }
        public long? ApprovedBy { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }

        public virtual Users ApprovedByNavigation { get; set; }
        public virtual Iapp Iapp { get; set; }
        public virtual IappBuildVersions IappBuildVersions { get; set; }
    }
}
