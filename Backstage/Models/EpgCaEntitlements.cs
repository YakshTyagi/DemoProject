using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgCaEntitlements
    {
        public long EntId { get; set; }
        public long EventId { get; set; }
        public int CaSubId { get; set; }

        public virtual CaEntitlements CaSub { get; set; }
        public virtual EpgEvents Event { get; set; }
    }
}
