using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetAdditionalDetails
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }
        public long? ApprovalBy { get; set; }
        public DateTime? ModificationTime { get; set; }
        public DateTime? IngestionTime { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
