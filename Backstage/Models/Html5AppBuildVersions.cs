using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Html5AppBuildVersions
    {
        public Html5AppBuildVersions()
        {
            Html5FileDetails = new HashSet<Html5FileDetails>();
        }

        public long BuildId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public long ApplicationId { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IngestionStatus { get; set; }

        public virtual Html5Apps Application { get; set; }
        public virtual ICollection<Html5FileDetails> Html5FileDetails { get; set; }
    }
}
