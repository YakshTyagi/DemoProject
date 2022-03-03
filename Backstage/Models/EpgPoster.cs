using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgPoster
    {
        public EpgPoster()
        {
            EpgEventIdentifiers = new HashSet<EpgEventIdentifiers>();
        }

        public long IngestUrlId { get; set; }
        public string IngestUrl { get; set; }

        public virtual ICollection<EpgEventIdentifiers> EpgEventIdentifiers { get; set; }
    }
}
