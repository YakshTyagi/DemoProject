using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgCasting
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string Actor { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }

        public virtual EpgEvents Event { get; set; }
    }
}
