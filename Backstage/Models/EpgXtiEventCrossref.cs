using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgXtiEventCrossref
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public int XtiEventId { get; set; }
        public string ProgramKey { get; set; }

        public virtual EpgEvents Event { get; set; }
    }
}
