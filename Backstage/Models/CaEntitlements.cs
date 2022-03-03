using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class CaEntitlements
    {
        public CaEntitlements()
        {
            EpgCaEntitlements = new HashSet<EpgCaEntitlements>();
        }

        public int CaSubId { get; set; }
        public int CaId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EpgCaEntitlements> EpgCaEntitlements { get; set; }
    }
}
