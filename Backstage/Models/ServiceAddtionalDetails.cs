using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceAddtionalDetails
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CountryId { get; set; }
        public int ShowId { get; set; }
        public string Keywords { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }
        public long? ApprovalBy { get; set; }
        public DateTime? ModificationTime { get; set; }
        public DateTime? IngestionTime { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }

        public virtual Users ApprovalByNavigation { get; set; }
        public virtual Countries Country { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Services Service { get; set; }
        public virtual ShowTypes Show { get; set; }
    }
}
