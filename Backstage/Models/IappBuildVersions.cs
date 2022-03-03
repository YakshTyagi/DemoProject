using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class IappBuildVersions
    {
        public IappBuildVersions()
        {
            IappFileDetails = new HashSet<IappFileDetails>();
            Ischedule = new HashSet<Ischedule>();
        }

        public long BuildId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public long ApplicationId { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IngestionStatus { get; set; }
        public bool ApprovalStatus { get; set; }

        public virtual Iapp Application { get; set; }
        public virtual ICollection<IappFileDetails> IappFileDetails { get; set; }
        public virtual ICollection<Ischedule> Ischedule { get; set; }
    }
}
