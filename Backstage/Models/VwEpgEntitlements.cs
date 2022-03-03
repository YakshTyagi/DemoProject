using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwEpgEntitlements
    {
        public long EventId { get; set; }
        public int CaSubId { get; set; }
        public int CaId { get; set; }
        public string Name { get; set; }
    }
}
