using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwApplicationDetails
    {
        public long IappId { get; set; }
        public string Itvid { get; set; }
        public string AppName { get; set; }
        public long CycleTime { get; set; }
        public long SatValue { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public DateTime? LastModified { get; set; }
        public long BuildId { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime? IngestionDatetime { get; set; }
        public DateTime? IngestedDatetime { get; set; }
        public long? ApprovedBy { get; set; }
    }
}
